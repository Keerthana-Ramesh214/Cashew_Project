using System;
using System.Collections.Generic;

#nullable disable

namespace OrderDetailsAPI.Models
{
    public partial class AdminDetail
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
    }
}
