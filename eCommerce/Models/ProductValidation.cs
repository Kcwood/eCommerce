using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public partial class Product
    {

    }
    public class ProductValidation
    {
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required, Display(Name="Our Price")]
        public decimal UnitPrice { get; set; }
        [Required, Display(Name="Asking Price")]
        public decimal ListPrice { get; set; }
        [Required, Display(Name="Supplier")]
        public int SupplierID { get; set; }
        [Required, Display(Name="In Stock")]
        public bool InStock { get; set; }
        [Required]
        public int CategoryID { get; set; }
    }
}