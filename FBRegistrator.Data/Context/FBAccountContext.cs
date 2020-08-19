using Microsoft.EntityFrameworkCore;

namespace FBRegistrator.Data.Context
{
    public class FBAccountContext : DbContext
    {
        public FBAccountContext(DbContextOptions<FBAccountContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FBAccount> FBAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
        }
    }
}