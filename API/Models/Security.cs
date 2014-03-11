using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investments.Models
{
    public class Security
    {
        public int Id { get; set; }
        public int Symbol { get; set; }
        public int Name { get; set; }
        public int SecurityTypeId { get; set; }
        public int MarketId { get; set; }

        public virtual SecurityType SecurityType { get; set; }
        public virtual Market Market { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}