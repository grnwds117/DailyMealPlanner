//
// Класс для времени приёма пищи
// 

namespace DailyMealPlanner.Business_Layer
{
    public class MealTime
    {
        public string Name { get; set; }
        public List<Product> SelectedProducts { get; set; }

        public MealTime()
        {
            Name = "";
            SelectedProducts = new List<Product>();
        }

        public MealTime(string name, List<Product> selectedProducts)
        {
            Name = name;
            SelectedProducts = selectedProducts;
        }
    }
}
