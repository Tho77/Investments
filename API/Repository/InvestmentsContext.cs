using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Investments.Models;

namespace Investments.Repository
{
    public class InvestmentsContext : DataContext
    {
        static InvestmentsContext()
        {
            Database.SetInitializer<InvestmentsContext>(null);
        }

        public InvestmentsContext() : base("Name=InvestmentsContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<DebitCreditType> DebitCreditTypes { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Security> Securitys { get; set; }
        public DbSet<SecurityType> SecurityTypes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}