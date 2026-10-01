using Microsoft.AspNetCore.Mvc;
using p6.Models;
using System.Collections.Generic;
using System.Linq;

namespace p6.Controllers
{
    public class ProductController : Controller
    {
        // In-memory static list simulating a database repository
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Wireless Headphone", Description = "High quality noise cancelling headphones.", Price = 199.99m, Category = "Electronics", ImageUrl = "https://picsum.photos/id/1/300/200", IsInStock = true },
            new Product { Id = 2, Name = "Smart Watch", Description = "Fitness tracker with heart rate monitor.", Price = 149.50m, Category = "Electronics", ImageUrl = "https://picsum.photos/id/2/300/200", IsInStock = true },
            new Product { Id = 3, Name = "Leather Backpack", Description = "Durable genuine leather backpack for laptops.", Price = 89.00m, Category = "Fashion", ImageUrl = "https://picsum.photos/id/3/300/200", IsInStock = false }
        };

        // GET: /Product or /Product/Index
        public IActionResult Index(string? searchCategory)
        {
            var categories = _products.Select(p => p.Category).Distinct().ToList();
            ViewBag.Categories = categories;

            var products = string.IsNullOrEmpty(searchCategory)
                ? _products
                : _products.Where(p => p.Category.Equals(searchCategory, System.StringComparison.OrdinalIgnoreCase)).ToList();

            return View(products);
        }

        // GET: /Product/Details/5
        public IActionResult Details(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: /Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
                _products.Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
    }
}
