using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class AdminDetails
    {
        public int AdminId { get; set; }
        [DisplayName("Username")]
        public string AdminName { get; set; }
        [DisplayName("Password")]
        public string AdminPassword { get; set; }
    }
}
