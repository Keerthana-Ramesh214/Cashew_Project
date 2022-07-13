using System;
using System.Collections.Generic;

#nullable disable

namespace OrderDetailsAPI.Models
{
    public partial class UserRegistration
    {
        public long PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string DeliveryAddress { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
