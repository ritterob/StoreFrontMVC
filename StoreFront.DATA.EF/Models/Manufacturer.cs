using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; } = null!;
        public string? ManufacturerAddress { get; set; }
        public string? ManufacturerCity { get; set; }
        public string? ManufacturerState { get; set; }
        public string? ManufacturerZip { get; set; }
        public string? ManufacturerPhone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
