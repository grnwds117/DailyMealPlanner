using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using DailyMealPlanner.Business_Layer;
using System.Collections.Generic;
using DailyMealPlanner.Forms;

namespace DailyMealPlanner
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private string userFilePath = "user.xml";

        // Конструктор теперь принимает путь к файлу для MealService
        public MainForm()
        {
            InitializeComponent();
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
