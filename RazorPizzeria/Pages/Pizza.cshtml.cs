using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Carbonara",
                PizzaName = "Carbonara",
                BasePrice = 2,
                FinalPrise = 5,
                Peperoni = true,
                Cheese = true,
                TomatoSauce = true,
            },

            new PizzasModel()
            {
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 2,
                FinalPrise = 4,
                Cheese = true,
                TomatoSauce = true,
            },

            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                PizzaName = "Margerita",
                BasePrice = 2,
                FinalPrise = 4,
                Cheese = true,
                TomatoSauce = true,
                Ham = true
            },

            new PizzasModel()
            {
                ImageTitle = "Mushroom",
                PizzaName = "Mushroom",
                BasePrice = 2,
                FinalPrise = 4,
                Cheese = true,
                TomatoSauce = true,
                Mushroom = true
            },

            new PizzasModel()
            {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice = 2,
                FinalPrise = 4,
                Cheese = true,
                TomatoSauce = true,
                Tuna = true
            },

            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
                BasePrice = 2,
                FinalPrise = 4,
                Cheese = true,
                TomatoSauce = true,
                Pineaple = true,
            },

            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PizzaName = "MeatFeast",
                BasePrice = 2,
                FinalPrise = 4,
                Cheese = true,
                TomatoSauce = true,
                Ham = true,
                Beef = true
            },

            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 2,
                FinalPrise = 4,
                Cheese = true,
                TomatoSauce = true,
                Peperoni = true
            },

            new PizzasModel()
            {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                BasePrice = 2,
                FinalPrise = 4,
                Cheese = true,
                TomatoSauce = true,
                Pineaple = true,
            }
        };
        public void OnGet()
        {
        }
    }
}
