using Microsoft.EntityFrameworkCore;
using SimpleTrader.Domain.Models;
using System;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AssetTransactions> AssetTransactions { get; set; }

        public SimpleTraderDbContext(DbContextOptions options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransactions>().OwnsOne(a => a.Stock); //Example for Owns Entity type https://docs.microsoft.com/en-us/ef/core/modeling/owned-entities
            base.OnModelCreating(modelBuilder);
        }

    }
}
