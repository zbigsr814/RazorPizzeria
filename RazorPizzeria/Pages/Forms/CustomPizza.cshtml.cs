using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrise { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            PizzaPrise = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrise += 1;
            if (Pizza.Cheese) PizzaPrise += 1;
            if (Pizza.Peperoni) PizzaPrise += 1;
            if (Pizza.Mushroom) PizzaPrise += 1;
            if (Pizza.Tuna) PizzaPrise += 1;
            if (Pizza.Pineaple) PizzaPrise += 1;
            if (Pizza.Ham) PizzaPrise += 1;
            if (Pizza.Beef) PizzaPrise += 1;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrise});
        }
    }
}