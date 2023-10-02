using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebServerAppExam.Data;
using WebServerAppExam.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebServerAppExam.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Product> Products { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _context = db;
        }

        // Handling the page load and search functionality
        public IActionResult OnGet(string searchString)
        {
            // Retrieving all products initially
            var products = from p in _context.Products select p;

            // Filtering the products based on the search string
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductId.Contains(searchString) || s.ProductDescription.Contains(searchString));
            }

            // Assigning the filtered products to the Products property
            Products = products.ToList();
            return Page();
        }
    }
}
