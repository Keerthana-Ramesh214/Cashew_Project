using System;
using System.Collections.Generic;

#nullable disable

namespace Admin_API.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
    }
}
