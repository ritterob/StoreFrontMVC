using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductsXorders = new HashSet<ProductsXorder>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public string? ProductPhoto { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? ProductQuantity { get; set; }
        public bool? ProductInStock { get; set; }
        public int? CategoryId { get; set; }
        public int? ManufacturerId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Manufacturer? Manufacturer { get; set; }
        public virtual ICollection<ProductsXorder> ProductsXorders { get; set; }
    }
}
