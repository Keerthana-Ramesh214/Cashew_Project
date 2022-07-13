using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Models
{
   
        public partial class AdminDetail
        {
            public int AdminId { get; set; }
            public string AdminName { get; set; }
            public string AdminPassword { get; set; }
        
    }
}
