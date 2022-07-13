using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public partial class UserRegistration
    {



        public long PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayName("Date Of Birth")]

       [DataType(DataType.Date)]
        public DateTime? Dob { get; set; }
        public string DeliveryAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }

    }
    
}
