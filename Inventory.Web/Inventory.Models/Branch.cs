using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        [Required]

        public string BranchName { get; set; }

        public string Description { get; set; }
        [Display(Name = "Currency")]

        public int CurrencyId { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
       
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
