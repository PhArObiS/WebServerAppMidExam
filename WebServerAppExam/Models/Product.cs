using System.ComponentModel.DataAnnotations;

namespace WebServerAppExam.Models
{
    public class Product
    {
        // public Product(string id, string productName, double productPrice)
        [Key]
        [Display(Name = "Product Id")]
        public string ProductId { get; set; }

        // public string ProductName { get; set; }
        [Required]
        [Display(Name = "Product Description")]
        [StringLength(50)]
        public string ProductDescription { get; set; }

        // public double ProductPrice { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        // public double ProductPrice { get; set; }
        [Required]
        [Display(Name = "Buy Price")]
        public double BuyPrice { get; set; }

        // public double ProductPrice { get; set; }
        [Required]
        [Display(Name = "Sell Price")]
        public double SellPrice { get; set; }



    }
}
