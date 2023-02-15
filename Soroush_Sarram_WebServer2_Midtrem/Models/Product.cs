using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Soroush_Sarram_WebServer2_Midtrem.Models
{
    public class Product
    {
        [Key]
        public string ProductId 
        { 
            get; set; 
        }

        [Required]
        [Display(Name = "ProductDescription")]
        public string ProductDescription
        { 
            get; set; 
        }

        [Required]
        [Display(Name = "Quantity")]
        public int Quantity 
        { 
            get; set; 
        }

        [Required]
        [Display(Name = "BuyPrice")]
        public double BuyPrice 
        { 
            get; set; 
        }


        [Required]
        [Display(Name = "SellPrice")]
        public double SellPrice 
        { 
            get; set; 
        }

        public Product()
        {

        }
    }
}
