using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyMealPlanner.Business_Layer
{
    public class MealTime
    {
        public string Name { get; set; }
        public List<Product> SelectedProducts { get; set; } = new List<Product>();

        public MealTime()
        {
            Name = "";
        }

        public MealTime(string name, List<Product> selectedProducts)
        {
            Name = name;
            SelectedProducts = selectedProducts;
        }
    }
}
