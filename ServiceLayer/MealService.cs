using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml.Linq;

namespace DailyMealPlanner.Business_Layer
{
    public class MealService
    {
        public List<Category> MealData { get; private set; } = new List<Category>();
        public MealTime Breakfast { get; set; } = new MealTime();
        public MealTime Lunch { get; set; } = new MealTime();
        public MealTime Dinner { get; set;  } = new MealTime();

        public void LoadData()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "data.xml");
            XElement db = XElement.Load(filePath);

            foreach (var categoryElement in db.Elements("Category"))
            {
                string categoryName = categoryElement.Attribute("name")?.Value;
                var categoryProducts = new List<Product>();

                foreach (var productElement in categoryElement.Elements("Product"))
                {
                    
                    var product = new Product
                    {
                        Name = productElement.Element("Name")?.Value,
                        Gramms = double.TryParse(productElement.Element("Gramms")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double gramms) ? gramms : 0,
                        Proteins = double.TryParse(productElement.Element("Protein")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double protein) ? protein : 0,
                        Fats = double.TryParse(productElement.Element("Fats")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double fats) ? fats : 0,
                        Carbs = double.TryParse(productElement.Element("Carbs")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double carbs) ? carbs : 0,
                        Calories = double.TryParse(productElement.Element("Calories")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double calories) ? calories : 0
                    };

                    categoryProducts.Add(product);
                }

                if (!string.IsNullOrEmpty(categoryName))
                {
                    var category = new Category(categoryName, categoryProducts);
                    MealData.Add(category);
                }
            }
        }

        public void LoadUserMenu()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "usermenu.xml");

            if (!File.Exists(filePath))
            {
                // Если файл не существует, просто возвращаем
                return;
            }

            XElement root = XElement.Load(filePath);

            // Очищаем текущие данные перед загрузкой
            Breakfast.SelectedProducts.Clear();
            Lunch.SelectedProducts.Clear();
            Dinner.SelectedProducts.Clear();

            foreach (var mealElement in root.Elements("Meal"))
            {
                string type = mealElement.Attribute("type")?.Value;

                foreach (var productElement in mealElement.Elements("Product"))
                {
                    var product = new Product
                    {
                        Name = productElement.Element("Name")?.Value,
                        Gramms = double.TryParse(productElement.Element("Gramms")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double gramms) ? gramms : 0,
                        Proteins = double.TryParse(productElement.Element("Protein")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double protein) ? protein : 0,
                        Fats = double.TryParse(productElement.Element("Fats")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double fats) ? fats : 0,
                        Carbs = double.TryParse(productElement.Element("Carbs")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double carbs) ? carbs : 0,
                        Calories = double.TryParse(productElement.Element("Calories")?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double calories) ? calories : 0
                    };

                    // Распределяем продукт по соответствующему времени приема пищи
                    switch (type)
                    {
                        case "Morning":
                            Breakfast.SelectedProducts.Add(product);
                            break;
                        case "Lunch":
                            Lunch.SelectedProducts.Add(product);
                            break;
                        case "Dinner":
                            Dinner.SelectedProducts.Add(product);
                            break;
                    }
                }
            }
        }
    }
}
