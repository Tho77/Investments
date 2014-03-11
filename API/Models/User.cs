using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investments.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}