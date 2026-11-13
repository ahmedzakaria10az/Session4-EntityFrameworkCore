using System;
using System.Collections.Generic;
using System.Text;

namespace Session4_EntityFrameworkCore.Models
{
    internal class Branch
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; } 
        public string? Address { get; set; } 
        public string? PhoneNumber { get; set; }


        //Relationship with Manager (One-to-One)(Total-Total)
        public Manager BranchManager { get; set; } = null!;


        //Relationship with Account (One-to-Many)(Partial-Total)
        public ICollection<Account> BranchAccounts { get; set; } = new List<Account>();
    }
}
