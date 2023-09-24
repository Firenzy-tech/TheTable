using Microsoft.EntityFrameworkCore;
namespace TheTable.Api.Models.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Billing> Billings => Set<Billing>();
        public DbSet<CashRegister> CashRegisters => Set<CashRegister>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Food> Foods => Set<Food>();
        public DbSet<Table> Tables => Set<Table>();
        public DbSet<Waiter> Waiters => Set<Waiter>();
    }
}
