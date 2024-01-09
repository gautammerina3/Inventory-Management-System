using System;
using Microsoft.AspNetCore.Identity;

namespace Inventory.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string StreetAddress { get; set; }

        public string ZipCode { get; set; }
    }
}
