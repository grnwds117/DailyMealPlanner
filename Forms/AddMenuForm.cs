using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DailyMealPlanner.Business_Layer;

namespace DailyMealPlanner.Forms
{
    public partial class AddMenuForm : Form
    {
        public AddMenuForm(string mealType, MealService mealService)
        {
            InitializeComponent();
        }

    }
}
