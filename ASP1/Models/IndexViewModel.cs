using ASP1.Entities;

namespace ASP1.Models
{
    public class IndexViewModel
    {
        public List<Drink> DrinkList { get; set; }
        public List<Hotmeal> MealList { get; set; }
        public List<Fastfood> FoodList { get; set; }
    }
}
