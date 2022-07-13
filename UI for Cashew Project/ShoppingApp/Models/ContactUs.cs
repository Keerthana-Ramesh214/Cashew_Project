using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class ContactUs
    {
        public string MailId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public ContactUs()
        {

        }
        public ContactUs(ContactUs c)
        {
            this.MailId = c.MailId;
            this.Name = c.Name;
            this.Subject = c.Subject;
            this.Body = c.Body;
        }
    }
}
