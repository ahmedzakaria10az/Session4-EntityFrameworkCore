using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Session4_EntityFrameworkCore.Models
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; } 
        public string? AccountType { get; set; } 
        public string? PhoneNumber { get; set; } 
        public DateTime OpeningDate { get; set; }


        //Relationship with Branch (One-to-Many)(Partial-Total)
        public string? BranchCode { get; set; }
        public Branch? AccountBranch { get; set; }


        //Relationship with Transaction (Many-to-One)(Total-Partial)
        public ICollection<Transaction> AccountTransactions { get; set; } = new List<Transaction>();


        //Relationship with Customer (Many-to-Many)(Partial-Partial)
        public ICollection<AccountCustomer> AccountCustomers { get; set; } = new List<AccountCustomer>();
    }
}
