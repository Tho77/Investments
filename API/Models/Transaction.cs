using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investments.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int SecurityId { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public int TransactionTypeId { get; set; }
        public int DebitCreditTypeId { get; set; }

        public virtual Security Security { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual DebitCreditType DebitCreditType { get; set; }
    }
}