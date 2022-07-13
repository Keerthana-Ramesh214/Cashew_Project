using System;
using System.Collections.Generic;

#nullable disable

namespace Admin_API.Models
{
    public partial class ShoppingCart
    {
        public int ItemId { get; set; }
        public string ProductName { get; set; }
        public int? ProductPrice { get; set; }
        public int? Quantity { get; set; }
        public int? TotalPrice { get; set; }
    }
}
