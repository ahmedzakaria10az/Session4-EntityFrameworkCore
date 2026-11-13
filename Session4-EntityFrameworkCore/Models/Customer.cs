using System;
using System.Collections.Generic;
using System.Text;

namespace Session4_EntityFrameworkCore.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public string? FullName { get; set; } 
        public string? Email { get; set; } 
        public string? PhoneNumber { get; set; } 
        public string? CustomerType { get; set; }
        public int NationalId { get; set; }

        //Relationship with Customer (Many-to-Many)(Partial-Partial)
        public ICollection<AccountCustomer> CustomerAccounts { get; set; } = new List<AccountCustomer>();
    }
}
