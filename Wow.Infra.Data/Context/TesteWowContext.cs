using Microsoft.EntityFrameworkCore;
using Wow.Domain.Entities;
using Wow.Infra.Data.EntityConfig;

namespace Wow.Infra.Data.Context
{
    public class TesteWowContext : DbContext
    {
        private System.Data.Entity.DbSet<Account> Account { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=localhost;Database=testewow;User Id=sa;Password=Abc123!@#;Trusted_Connection=False;ConnectRetryCount=0");


        
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new AccountConfiguration());   
        }
    }
}