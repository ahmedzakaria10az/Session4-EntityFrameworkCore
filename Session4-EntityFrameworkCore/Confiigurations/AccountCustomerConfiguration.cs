using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session4_EntityFrameworkCore.Models;


namespace Session4_EntityFrameworkCore.Confiigurations
{
    internal class AccountCustomerConfiguration : IEntityTypeConfiguration<AccountCustomer>
    {
        public void Configure(EntityTypeBuilder<AccountCustomer> builder)
        {
            builder.HasKey(ac => new { ac.AccountNumber, ac.CustomerId });

            builder.Property(ac => ac.OwnershipType)
                   .IsRequired();

            builder.Property(ac => ac.OwnershipStartDate)
                   .IsRequired();

            builder.Property(ac => ac.AccountStatus)
                 .HasMaxLength(100)
                 .IsRequired();

      


            builder.HasOne(ac => ac.Account)
                   .WithMany(a => a.AccountCustomers)
                   .HasForeignKey(ac => ac.AccountNumber)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ac => ac.Customer)
                   .WithMany(c => c.CustomerAccounts)
                   .HasForeignKey(ac => ac.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
