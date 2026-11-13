using System;
using System.Collections.Generic;
using System.Text;

namespace Session4_EntityFrameworkCore.Models
{
    internal class Transaction
    {
        public int TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; } 
        public Decimal Amount { get; set; }
        public string? TransactionType { get; set; } 
        public string? Note { get; set; }


        //Relationship with Account (Many-to-One)(Total-Partial)
        public int AccountNumber { get; set; }
        public Account? TransactionAccount { get; set; }
    }
}
