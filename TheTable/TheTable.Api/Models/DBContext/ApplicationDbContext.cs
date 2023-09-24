using Microsoft.EntityFrameworkCore;
namespace TheTable.Api.Models.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Billing>().HasKey(b => b.BillingID);
            modelBuilder.Entity<CashRegister>().HasKey(b => b.CashRegisterId);
            modelBuilder.Entity<Food>().HasKey(c => c.FoodID);
            modelBuilder.Entity<Table>().HasKey(d => d.TableID);
            modelBuilder.Entity<Waiter>().HasKey(e => e.WaiterID);
        }

        public DbSet<Billing> Billings => Set<Billing>();
        public DbSet<CashRegister> CashRegisters => Set<CashRegister>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Food> Foods => Set<Food>();
        public DbSet<Table> Tables => Set<Table>();
        public DbSet<Waiter> Waiters => Set<Waiter>();
    }
}
