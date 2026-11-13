using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Session4_EntityFrameworkCore.Models;
using Session4_EntityFrameworkCore.Confiigurations;

    internal class NationalBankDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=NationalBankDB;Trusted_Connection=True;TrustServerCertificate=True");        
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BranchConfiguration());

        modelBuilder.ApplyConfiguration(new ManagerConfiguration());

        modelBuilder.ApplyConfiguration(new AccountConfiguration());

        modelBuilder.ApplyConfiguration(new CustomerConfiguration());

        modelBuilder.ApplyConfiguration(new TransactionConfiguration());

        modelBuilder.ApplyConfiguration(new AccountCustomerConfiguration());

    }
}
         