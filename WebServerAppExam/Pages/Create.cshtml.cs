using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebServerAppExam.Data;
using WebServerAppExam.Models;

namespace WebServerAppExam.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty] // Important!!!-----------------------
        public Product Product { get; set; } // Important!!!-----------------------

        private readonly ApplicationDbContext _context; // Important!!!-----------------------
        public CreateModel(ApplicationDbContext db) // Important!!!-----------------------
        {
            _context = db;
        }

        public void OnGet()
        {
        }

        // public void OnPost(string id, string productName, double productPrice)
        public IActionResult OnPost() // Important!!!-----------------------
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(Product); // Important!!!-----------------------
                _context.SaveChanges(); // Important!!!-----------------------

                return RedirectToPage("Index"); // Important!!!-----------------------

            }
            return Page();
        }
    }
}
