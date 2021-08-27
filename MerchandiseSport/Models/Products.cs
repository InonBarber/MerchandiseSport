using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerchandiseSport.Models
{
    interface Products
    {
        public int IdProduct { get; set; }
        public string TitleOfProduct { get; set; }
        public DateTime CreationDate { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public String ProductImage { get; set; }
    }
}
