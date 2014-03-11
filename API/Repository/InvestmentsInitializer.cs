using System;
using System.Collections.Generic;
using System.Data.Entity;
using Investments.Models;

namespace Investments.Repository
{
    public class InvestmentsInitializer : DropCreateDatabaseIfModelChanges<InvestmentsContext>
    {
        protected override void Seed(InvestmentsContext context)
        {
            var accounts = new List<Account>
            {
                new Account{ Description = "For retirement.", Name = "RRSP Account", Number = "83FX93KS", Type = "RRSP", UserId = 1 },
                new Account{ Description = "For emergencies.", Name = "TFSA Account", Number = "65IW32NW", Type = "TFSA", UserId = 1 }
            };
            accounts.ForEach(x => context.Accounts.Add(x));
            context.SaveChanges();

            var debitCreditTypes = new List<DebitCreditType>
            {
                new DebitCreditType{ Name = "Credit" },
                new DebitCreditType{ Name = "Debit" }
            };
            debitCreditTypes.ForEach(x => context.DebitCreditTypes.Add(x));
            context.SaveChanges();

            var markets = new List<Market>
            {
                new Market{ Name = "TSX" },
                new Market{ Name = "NASDAQ" }
            };
            markets.ForEach(x => context.Markets.Add(x));
            context.SaveChanges();

            var prices = new List<Price>
            {
                new Price{ Amount = 2.24m, DateTime = new DateTime(2014, 01, 02), SecurityId = 1 },
                new Price{ Amount = 2.33m, DateTime = new DateTime(2014, 01, 03), SecurityId = 1 },
                new Price{ Amount = 2.52m, DateTime = new DateTime(2014, 01, 04), SecurityId = 1 }
            };
            prices.ForEach(x => context.Prices.Add(x));
            context.SaveChanges();

            var securities = new List<Security>
            {
                new Security{ MarketId = 1, Name = "CDN Index", SecurityTypeId = 1, Symbol = "CDN-I" },
                new Security{ MarketId = 1, Name = "US Index", SecurityTypeId = 1, Symbol = "US-I" }
            };
            securities.ForEach(x => context.Securitys.Add(x));
            context.SaveChanges();

            var securityTypes = new List<SecurityType>
            {
                new SecurityType{ Name = "Mutual Fund" },
                new SecurityType{ Name = "Stock" }
            };
            securityTypes.ForEach(x => context.SecurityTypes.Add(x));
            context.SaveChanges();

            var transactions = new List<Transaction>
            {
                new Transaction{ Amount = 2000, DateTime = new DateTime(2014, 01, 02), DebitCreditTypeId = 1, Price = 2.33m, Quantity = 19, SecurityId = 1, TransactionTypeId = 1 },
                new Transaction{ Amount = 1500, DateTime = new DateTime(2014, 01, 04), DebitCreditTypeId = 1, Price = 2.52m, Quantity = 15, SecurityId = 1, TransactionTypeId = 1 }
            };
            transactions.ForEach(x => context.Transactions.Add(x));
            context.SaveChanges();

            var transactionTypes = new List<TransactionType>
            {
                new TransactionType{ Name = "Purchase" },
                new TransactionType{ Name = "Sell" }
            };
            transactionTypes.ForEach(x => context.TransactionTypes.Add(x));
            context.SaveChanges();

            var users = new List<User>
            {
                new User{ CreatedDate = DateTime.Now, FirstName = "Matt", LastName = "Ford", ModifiedDate = DateTime.Now, Password = "hashme" },
                new User{ CreatedDate = DateTime.Now, FirstName = "Jenny", LastName = "Glass", ModifiedDate = DateTime.Now, Password = "hashme" }
            };
            users.ForEach(x => context.Users.Add(x));
            context.SaveChanges();
        }
    }
}