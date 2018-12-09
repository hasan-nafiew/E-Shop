using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
   public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public long UserNameId { get; set; }
        public long PasswordId { get; set; }
        public long CustomerTypeId { get; set; }
        public bool Status { get; set; }

    }
}
