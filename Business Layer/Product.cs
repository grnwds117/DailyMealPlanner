using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyMealPlanner.Business_Layer
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public double Gramms { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbs { get; set; }

        public Product()
        {
            Name = "Default";
            Gramms = 0;
            Calories = 0;
            Proteins = 0;
            Fats = 0;
            Carbs = 0;
        }

        public Product(string name, double gramms, double calories, double proteins, double fats, double carbs)
        {
            Name = name;
            Gramms = gramms;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbs = carbs;
        }
    }
}
