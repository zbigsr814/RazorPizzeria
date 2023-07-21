using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]    // properties inside class is accessable in view, support get new value fro other view
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public string PizzaPrise { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrEmpty(ImageTitle)) 
            {
                ImageTitle = "Create";
            }
        }
    }
}
