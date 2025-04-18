namespace DailyMealPlanner.Business_Layer
{
    public class Category
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Category(string name, List<Product> products)
        {
            Name = name;
            Products = products;
        }
    }
}
