using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Session4_EntityFrameworkCore.Models
{
    [PrimaryKey(nameof(AccountNumber), nameof(CustomerId))] 
    internal class AccountCustomer
    {
        public int AccountNumber { get; set; }
        public int CustomerId { get; set; }
        public string? OwnershipType { get; set; }
        public DateTime OwnershipStartDate { get; set; }
        public string? AccountStatus { get; set; }

        //Relationship with Account (Many-to-One)(Total-Partial)
        public Account Account { get; set; } = null!;

        //Relationship with Customer (Many-to-One)(Total-Partial)
        public Customer Customer { get; set; } = null!;



    }
}
