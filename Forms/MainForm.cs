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

       
        public MainForm()
        {
            InitializeComponent();
            _mealService.LoadData();
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
                card.RemoveFoodCard += RemoveFoodCard;
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


            _mealService.SaveUserMenu();
            UpdateStats();
        }

        // Изначальная формула слегка изменена (к значению bmr добавлено 
        private double GetCalorieRate()
        {
            double arm, bmr;

            bmr = 1022.593 + 9.247 * currentUser.Weight + 3.098 * currentUser.Height - 4.330 * currentUser.Age;
            arm = currentUser.Activity == "Низкая" ? 1.2 :
                currentUser.Activity == "Нормальная" ? 1.375 :
                currentUser.Activity == "Умеренная" ? 1.5 : 1.725;

            return bmr + arm;

        }

        private void CalculateStats(out double proteins, out double fats, out double carbs, out double calories, out double dailyCalories)
        {
            proteins = fats = carbs = calories = dailyCalories = 0;

            var allProducts = _mealService.Breakfast.SelectedProducts
                              .Concat(_mealService.Lunch.SelectedProducts)
                              .Concat(_mealService.Dinner.SelectedProducts);

            foreach (var product in allProducts)
            {
                proteins += product.Proteins;
                fats += product.Fats;
                carbs += product.Carbs;
                calories += product.Calories;
            }

            dailyCalories = GetCalorieRate();
        }
            
        private void UpdateStats()
        {
            double proteins, fats, carbs, calories, dailyCalories;
            CalculateStats(out proteins, out fats, out carbs, out calories, out dailyCalories);

            ProteinLabel.Text = $"Белки: {proteins.ToString("F1", CultureInfo.InvariantCulture)} г";
            FatsLabel.Text = $"Жиры: {fats.ToString("F1", CultureInfo.InvariantCulture)} г";
            CarbsLabel.Text = $"Углеводы: {carbs.ToString("F1", CultureInfo.InvariantCulture)} г";
            CaloriesLabel.Text = $"Калории: {calories.ToString("F1", CultureInfo.InvariantCulture)} ккал";
            DailyCaloriesLabel.Text = $"Дневная норма калорий: {dailyCalories.ToString("F1", CultureInfo.InvariantCulture)} ккал";
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(userFilePath))
            {
                currentUser = User.LoadFromXml(userFilePath);
            }
            else
            {
                currentUser = new User(); 
                currentUser.SaveToXml(userFilePath);
            }

            UpdateUserLabels();
            LoadUserMenu();
            UpdateStats();

        }

        private void UpdateUserLabels()
        {
            WeightLabel.Text = $"Вес: {currentUser.Weight} кг";
            HeightLabel.Text = $"Рост: {currentUser.Height} см";
            AgeLabel.Text = $"Возраст: {currentUser.Age} лет";
            ActivityLabel.Text = $"Активность: {currentUser.Activity}";
        }


      
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mealService.SaveUserMenu();
        }

        public void EditUserButton_Click(object sender, EventArgs e)
        {
            EditUserForm ef = new EditUserForm(currentUser);
            if (ef.ShowDialog() == DialogResult.OK)
            {
                currentUser = User.LoadFromXml("user.xml");
                UpdateUserLabels();
                UpdateStats();
            }
        }

        private void MorningButton_Click(object sender, EventArgs e)
        {
            AddMenuForm af = new AddMenuForm(_mealService.MealData, _mealService.Breakfast);
            if (af.ShowDialog() == DialogResult.OK)
            {
                LoadUserMenu();
                UpdateStats();
            }
        }

        private void LunchButton_Click(object sender, EventArgs e)
        {
            AddMenuForm af = new AddMenuForm(_mealService.MealData, _mealService.Lunch);
            if (af.ShowDialog() == DialogResult.OK)
            {
                LoadUserMenu();
                UpdateStats();
            }
        }

        private void EveningButton_Click(object sender, EventArgs e)
        {
            AddMenuForm af = new AddMenuForm(_mealService.MealData, _mealService.Dinner);
            if (af.ShowDialog() == DialogResult.OK)
            {
                LoadUserMenu();
                UpdateStats();
            }
        }
    }
}
