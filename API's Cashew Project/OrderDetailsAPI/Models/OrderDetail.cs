using System;
using System.Collections.Generic;

#nullable disable

namespace OrderDetailsAPI.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? OrderDeliveryDate { get; set; }
        public long? CustomerMobNo { get; set; }
        public int? QuantityOrdered { get; set; }
        public int? OrderTotalAmount { get; set; }
    }
}
