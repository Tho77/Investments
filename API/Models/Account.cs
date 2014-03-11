using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investments.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}