using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class ShipmentType
    {
        public int Id { get; set; }
        [Required]

        public string ShipmentTypeName { get; set; }

        public string Description { get; set; }
    }
}
