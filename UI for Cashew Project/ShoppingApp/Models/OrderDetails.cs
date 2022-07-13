using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? OrderDeliveryDate { get; set; }
        public long? CustomerMobNo { get; set; }
        public int? OrderTotalAmount { get; set; }

        public int? QuantityOrdered { get; set; }

    }
}
