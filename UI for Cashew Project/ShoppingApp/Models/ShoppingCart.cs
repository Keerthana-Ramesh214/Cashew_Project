using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class ShoppingCart
    {
        public int ItemId { get; set; }
        public  string ProductName { get; set; }
        public  int ProductPrice { get; set; }
        public long PhoneNumber { get; set; }
        public  int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public ShoppingCart()
        {

        }

        public ShoppingCart(int ItemId, string ProductName, int ProductPrice,int Quantity,int TotalPrice,long PhoneNumber)
        {

            this.ItemId = ItemId;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.Quantity = Quantity;
            this.TotalPrice = TotalPrice;
            this.PhoneNumber = PhoneNumber;
        }


    }
}
