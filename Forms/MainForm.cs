using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using DailyMealPlanner.Business_Layer;
using System.Collections.Generic;
using DailyMealPlanner.Forms;
using System.Globalization;
using System.Xml.Linq;

namespace DailyMealPlanner
{
    public partial class MainForm : Form
    {
        private MealService _mealService = new MealService();
        private User currentUser;
        private string userFilePath = "user.xml";

        // Конструктор теперь принимает путь к файлу для MealService
        public MainForm()
        {
            InitializeComponent();
            _mealService.LoadUserMenu();
        }

        private void LoadUserMenu()
        {
            flowLayoutPanel1.Controls.Clear(); // Завтрак
            flowLayoutPanel2.Controls.Clear(); // Обед
            flowLayoutPanel3.Controls.Clear(); // Ужин

            foreach (var product in _mealService.Breakfast.SelectedProducts)
            {
                var card = new FoodCard { Product = product };
                card.RemoveFoodCard += RemoveFoodCard; // Подписываемся на событие
                flowLayoutPanel1.Controls.Add(card);
            }

            foreach (var product in _mealService.Lunch.SelectedProducts)
            {
                var card = new FoodCard { Product = product };
                card.RemoveFoodCard += RemoveFoodCard;
                flowLayoutPanel2.Controls.Add(card);
            }

            foreach (var product in _mealService.Dinner.SelectedProducts)
            {
                var card = new FoodCard { Product = product };
                card.RemoveFoodCard += RemoveFoodCard;
                flowLayoutPanel3.Controls.Add(card);
            }
        }

        private void RemoveFoodCard(FoodCard foodCard)
        {
            // Удаление из FlowLayoutPanel
            if (flowLayoutPanel1.Controls.Contains(foodCard))
            {
                flowLayoutPanel1.Controls.Remove(foodCard);
                _mealService.Breakfast.SelectedProducts.Remove(foodCard.Product);
            }
            else if (flowLayoutPanel2.Controls.Contains(foodCard))
            {
                flowLayoutPanel2.Controls.Remove(foodCard);
                _mealService.Lunch.SelectedProducts.Remove(foodCard.Product);
            }
            else if (flowLayoutPanel3.Controls.Contains(foodCard))
            {
                flowLayoutPanel3.Controls.Remove(foodCard);
                _mealService.Dinner.SelectedProducts.Remove(foodCard.Product);
            }

           
            SaveData();
        }

        private void SaveData()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "usermenu.xml");
            XElement root = new XElement("Menu");

            AddMealToXml(root, "Morning", _mealService.Breakfast.SelectedProducts);
            AddMealToXml(root, "Lunch", _mealService.Lunch.SelectedProducts);
            AddMealToXml(root, "Dinner", _mealService.Dinner.SelectedProducts);

            root.Save(filePath);
        }

        private void AddMealToXml(XElement root, string type, List<Product> products)
        {
            XElement mealElement = new XElement("Meal", new XAttribute("type", type));

            foreach (var product in products)
            {
                XElement productElement = new XElement("Product",
                    new XElement("Name", product.Name),
                    new XElement("Gramms", product.Gramms),
                    new XElement("Protein", product.Proteins),
                    new XElement("Fats", product.Fats),
                    new XElement("Carbs", product.Carbs),
                    new XElement("Calories", product.Calories)
                );
                mealElement.Add(productElement);
            }

            root.Add(mealElement);
        }

        // Загрузка данных при старте
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(userFilePath))
            {
                currentUser = User.LoadFromXml(userFilePath);
            }
            else
            {
                currentUser = new User(); // Дефолтные значения
                currentUser.SaveToXml(userFilePath); // Создаём файл
            }

            UpdateUserLabels();
            LoadUserMenu();

        }

        private void UpdateUserLabels()
        {
            WeightLabel.Text = $"Вес: {currentUser.Weight} кг";
            HeightLabel.Text = $"Рост: {currentUser.Height} см";
            AgeLabel.Text = $"Возраст: {currentUser.Age} лет";
            ActivityLabel.Text = $"Активность: {currentUser.Activity}";
        }

        // Сохранение данных перед закрытием
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void EditUserButton_Click(object sender, EventArgs e)
        {
            EditUserForm ef = new EditUserForm(currentUser);
            if (ef.ShowDialog() == DialogResult.OK)
            {
                currentUser = User.LoadFromXml("user.xml");
                UpdateUserLabels();
            }
        }

    }
}
