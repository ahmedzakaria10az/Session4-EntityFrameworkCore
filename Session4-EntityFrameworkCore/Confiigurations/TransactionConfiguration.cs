using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session4_EntityFrameworkCore.Models;

namespace Session4_EntityFrameworkCore.Confiigurations
{
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.TransactionNumber);

            builder.Property(t => t.TransactionDate)
                   .IsRequired();

            builder.Property(t => t.Amount)
                   .HasPrecision(10, 2)
                   .IsRequired();

            builder.Property(t => t.TransactionType)
                 .HasMaxLength(100)
                 .IsRequired();

            builder.Property(t => t.Note)
                 .HasMaxLength(500);



            builder.HasOne(t => t.TransactionAccount)
                   .WithMany(a => a.AccountTransactions)
                   .HasForeignKey(t => t.AccountNumber)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
