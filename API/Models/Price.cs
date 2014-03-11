using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investments.Models
{
    public class Price
    {
        public int Id { get; set; }
        public int SecurityId { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }

        public virtual Security Security { get; set; }
    }
}