using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MerchandiseSport.Models
{
    public class Product
    {
        [Key]
        public int SerialNumber { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public String ProductImage { get; set; } 
    }
}
