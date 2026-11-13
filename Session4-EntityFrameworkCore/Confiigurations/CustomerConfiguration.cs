using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session4_EntityFrameworkCore.Models;


namespace Session4_EntityFrameworkCore.Confiigurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Address)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(c => c.DateOfBirth)
                   .IsRequired();

            builder.Property(c => c.FullName)
                 .HasMaxLength(100)
                 .IsRequired();

            builder.Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.PhoneNumber)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(c => c.CustomerType)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(c => c.NationalId)
               .IsRequired();
        }
    }
}
