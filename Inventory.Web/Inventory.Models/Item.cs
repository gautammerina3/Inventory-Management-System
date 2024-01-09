﻿using System;
namespace Inventory.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public int AvailQuantity { get; set; }

        public Status Status { get; set; }
    }

    public enum Status
    {
        OK, Defective
    }
}

