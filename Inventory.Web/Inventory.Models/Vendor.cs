using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [Required]

        public string VendorName { get; set; }
        [Display(Name ="Vendor Type")]
        public int VendorTypeId { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
    }
}
