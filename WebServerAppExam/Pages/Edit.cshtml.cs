using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebServerAppExam.Data;
using WebServerAppExam.Models;

namespace WebServerAppExam.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }
        private readonly ApplicationDbContext _context;
        public EditModel(ApplicationDbContext db)
        {
            _context = db;
        }
        public void OnGet(string id)
        {
            Product = _context.Products.Find(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(Product);
                _context.SaveChanges();

                return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
