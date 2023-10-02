using Microsoft.EntityFrameworkCore;
using WebServerAppExam.Models;

namespace WebServerAppExam.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // Important!!!-----------------------
        {
        }

        public DbSet<Product> Products { get; set; } // Important!!!-----------------------
    }
}