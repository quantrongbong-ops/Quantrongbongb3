using Microsoft.AspNetCore.Mvc;
using Quantrongbongb3.Models;

namespace Quantrongbongb3.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _products = new List<Product>
{

new Product { Id = 1, Name = "Laptop", Price = 1500, Description =
"Powerful laptop" },
new Product { Id = 2, Name = "Mouse", Price = 25, Description =
"Wireless mouse" },
new Product { Id = 3, Name = "Keyboard", Price = 50, Description =
"Mechanical keyboard" }
};
        public IActionResult Index()
        {
            return View(_products);
        }
    }
}
