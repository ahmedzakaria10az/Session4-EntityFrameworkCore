using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Session4_EntityFrameworkCore.Models;

namespace Session4_EntityFrameworkCore.Confiigurations
{
    internal class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(b => b.Code);

            builder.Property(b => b.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(b => b.Address)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(b => b.PhoneNumber)
                 .HasMaxLength(11)
                 .IsRequired();



            builder.HasOne(b => b.BranchManager)
           .WithOne(m => m.ManagedBranch)
           .HasForeignKey<Manager>(m => m.BranchCode);


            builder.HasData(new Branch
            {
                Code = "BR01",
                Name = "Cairo Branch",
                Address = "Cairo, Egypt",
                PhoneNumber = "0123456789",
            },
               new Branch
               {
                   Code = "BR02",
                   Name = "Alexandria Branch",
                   Address = "Alexandria, Egypt",
                   PhoneNumber = "0104785235"
               }
           );
        }
    }
}
