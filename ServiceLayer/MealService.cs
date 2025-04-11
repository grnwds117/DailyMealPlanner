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

                    product.Proteins /= 100;
                    product.Fats /= 100;
                    product.Carbs /= 100;

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
                return;
            }

            XElement root = XElement.Load(filePath);

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

        public void SaveUserMenu()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "usermenu.xml");
            XElement root = new XElement("Menu");

            AddMealToXml(root, "Morning", Breakfast.SelectedProducts);
            AddMealToXml(root, "Lunch", Lunch.SelectedProducts);
            AddMealToXml(root, "Dinner", Dinner.SelectedProducts);

            root.Save(filePath);
        }

        private void AddMealToXml(XElement root, string type, List<Product> products)
        {
            XElement mealElement = new XElement("Meal", new XAttribute("type", type));

            foreach (var product in products)
            {
                XElement productElement = new XElement("Product",
                    new XElement("Name", product.Name),
                    new XElement("Gramms", product.Gramms.ToString(CultureInfo.InvariantCulture)),
                    new XElement("Protein", product.Proteins.ToString(CultureInfo.InvariantCulture)),
                    new XElement("Fats", product.Fats.ToString(CultureInfo.InvariantCulture)),
                    new XElement("Carbs", product.Carbs.ToString(CultureInfo.InvariantCulture)),
                    new XElement("Calories", product.Calories.ToString(CultureInfo.InvariantCulture))
                );

                mealElement.Add(productElement);
            }

            root.Add(mealElement);
        }

    }
}
