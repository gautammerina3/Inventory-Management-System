using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        public string BarCode { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        public string ProductImage { get; set; }
        [Display(Name = "Measure Unit")]
        public int MeasureUnitId { get; set; }

        public double BuyingPrice { get; set; }

        public double SellingPrice { get; set; }
        [Display(Name = "Branch")]
        public int BranchId { get; set; }

        [Display(Name ="Currency")]
        public int CurrencyId { get; set; }
    }
}
