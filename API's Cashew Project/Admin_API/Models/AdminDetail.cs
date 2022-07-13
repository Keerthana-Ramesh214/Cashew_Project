using System;
using System.Collections.Generic;

#nullable disable

namespace Admin_API.Models
{
    public partial class AdminDetail
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
    }
}
