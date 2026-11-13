using System;
using System.Collections.Generic;
using System.Text;

namespace Session4_EntityFrameworkCore.Models
{
    internal class Manager
    {
        public int Id { get; set; }
        public string? FullName { get; set; } 
        public string? Email { get; set; } 
        public string? PhoneNumber { get; set; } 
        public DateTime HireDate { get; set; }



        //Relationship with Branch (One-to-One)(Total-Total)
        public Branch ManagedBranch { get; set; }=null!;

        public string BranchCode { get; set; } = null!;


    }
}
