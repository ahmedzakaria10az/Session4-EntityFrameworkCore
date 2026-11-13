using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session4_EntityFrameworkCore.Models;


namespace Session4_EntityFrameworkCore.Confiigurations
{
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a => a.AccountNumber);

            builder.Property(a => a.CurrentBalance)
                   .HasPrecision(10,2)
                   .IsRequired();

            builder.Property(a => a.AccountType)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(a => a.PhoneNumber)
                 .HasMaxLength(11)
                 .IsRequired();

            builder.Property(a => a.OpeningDate)
                .IsRequired();


            builder.HasOne(a => a.AccountBranch)
                   .WithMany(b => b.BranchAccounts)
                   .HasForeignKey(a => a.BranchCode)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
