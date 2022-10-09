using ASP1.Entities;
using ASP1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Name="Coca Cola",
                    Amount=10
                },
                new Drink
                {
                    Name="Fanta",
                    Amount=15
                },
                new Drink
                {
                    Name="IceTea",
                    Amount=17
                }
            };
            List<Hotmeal> meals = new List<Hotmeal>
            {
                new Hotmeal
                {
                    Name="Vegetable Soup",
                    Amount=10
                },
                new Hotmeal
                {
                    Name="Beef",
                    Amount=15
                },
                new Hotmeal
                {
                    Name="Rice",
                    Amount=17
                }
            };
            List<Fastfood> food = new List<Fastfood>
            {
                new Fastfood
                {
                    Name="Hamburger",
                    Amount=20
                },
                new Fastfood
                {
                    Name="Cheeseburger",
                    Amount=25
                },
                new Fastfood
                {
                    Name="French Fries",
                    Amount=18
                }
            };
            var viewModel = new IndexViewModel { DrinkList = drinks, MealList = meals, FoodList = food };
            return View(viewModel);
        }

        public ViewResult Drink()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Name="Coca Cola",
                    Amount=10
                },
                new Drink
                {
                    Name="Fanta",
                    Amount=15
                },
                new Drink
                {
                    Name="IceTea",
                    Amount=17
                }
            };
            return View(drinks);
        }

        public ViewResult Hotmeal()
        {
            List<Hotmeal> meals = new List<Hotmeal>
            {
                new Hotmeal
                {
                    Name="Vegetable Soup",
                    Amount=10
                },
                new Hotmeal
                {
                    Name="Beef",
                    Amount=15
                },
                new Hotmeal
                {
                    Name="Rice",
                    Amount=17
                }
            };
            return View(meals);
        }

        public ViewResult Fastfood()
        {
            List<Fastfood> food = new List<Fastfood>
            {
                new Fastfood
                {
                    Name="Hamburger",
                    Amount=20
                },
                new Fastfood
                {
                    Name="Cheeseburger",
                    Amount=25
                },
                new Fastfood
                {
                    Name="French Fries",
                    Amount=18
                }
            };
            return View(food);
        }
    }
}
