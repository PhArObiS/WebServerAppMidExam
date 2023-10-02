using Microsoft.AspNetCore.Mvc.RazorPages;
using WebServerAppExam.Data;
using System.Linq;

namespace WebServerAppExam.Pages
{
    public class StockInfoModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public double TotalValue { get; set; }
        public double AveragePrice { get; set; }
        public double TotalProfit { get; set; }

        public StockInfoModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (_context.Products.Any())
            {
                TotalValue = _context.Products.Sum(p => p.SellPrice * p.Quantity);
                AveragePrice = _context.Products.Average(p => p.SellPrice);
                TotalProfit = _context.Products.Sum(p => (p.SellPrice - p.BuyPrice) * p.Quantity);
            }
        }
    }
}
