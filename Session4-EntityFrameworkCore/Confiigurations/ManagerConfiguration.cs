using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session4_EntityFrameworkCore.Models;

namespace Session4_EntityFrameworkCore.Confiigurations
{
    internal class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.FullName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(m => m.Email)
                   .IsRequired();

            builder.Property(m => m.PhoneNumber)
                   .IsRequired();

            builder.Property(m => m.HireDate)
                   .IsRequired();



            builder.HasData(
                new Manager
                {
                    Id = 1,
                    BranchCode = "BR01",
                    FullName = "Ahmed Mohamed",
                    Email = "ahmed@bank.com",
                    PhoneNumber = "01012345678",
                    HireDate = new DateTime(2020,1,1)
                },
                new Manager
                {
                    Id = 2 ,
                    BranchCode = "BR02",
                    FullName = "Omar Ali",
                    Email = "omar@bank.com",
                    PhoneNumber = "01112345678",
                    HireDate = new DateTime(2021,5,1)
                }
            );
        }
    }
}
