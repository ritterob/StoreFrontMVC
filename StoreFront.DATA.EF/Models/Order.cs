using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Order
    {
        public Order()
        {
            ProductsXorders = new HashSet<ProductsXorder>();
        }

        public int OrderId { get; set; }
        public decimal? OrderTotal { get; set; }
        public string? CustomerId { get; set; }
        public string? EmployeeId { get; set; }

        public virtual User? Customer { get; set; }
        public virtual User? Employee { get; set; }
        public virtual ICollection<ProductsXorder> ProductsXorders { get; set; }
    }
}
