using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }


    }
}
