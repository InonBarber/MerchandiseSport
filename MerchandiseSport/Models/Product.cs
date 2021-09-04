using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MerchandiseSport.Models
{
    public enum ProductSize
    {
        S = 1, 
        M = 2,
        L = 3,
        XL = 4 
    }

   
    public class Product
    {
        [Key]
        public int SerialNumber { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public ProductSize Size { get; set; }
        public int Price { get; set; }
        public String ProductImage { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
