using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebServerAppExam.Data;
using WebServerAppExam.Models;

namespace WebServerAppExam.Pages
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Product Products { get; set; }
        [BindProperty]
        public string TempProductId { get; set; }

        private readonly ApplicationDbContext _context;
        public DeleteModel(ApplicationDbContext db)
        {
            _context = db;
        }
        public void OnGet(string id)
        {
            Products = _context.Products.Find(id);
        }
        public IActionResult OnPost()
        {

            var productToDelete = _context.Products.Find(Products.ProductId);

            if (productToDelete != null)
            {
                _context.Remove(productToDelete);
                _context.SaveChanges();
            }

            return RedirectToPage("Index");
        }
    }
}
