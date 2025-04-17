using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyMealPlanner.Forms
{
    public partial class EditUserForm : Form
    {
        private User currentUser;

        public EditUserForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            WeightTextBox.Text = currentUser.Weight.ToString();
            HeightTextBox.Text = currentUser.Height.ToString();
            AgeTextBox.Text = currentUser.Age.ToString();
            ActivityComboBox.Text = currentUser.Activity;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            currentUser.Weight = int.Parse(WeightTextBox.Text);
            currentUser.Height = int.Parse(HeightTextBox.Text);
            currentUser.Age = int.Parse(AgeTextBox.Text);
            currentUser.Activity = ActivityComboBox.Text;

            currentUser.SaveToXml("user.xml");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
