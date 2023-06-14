using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class ProductsXorder
    {
        public int ProductOrderId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal? ProductOrderSubTotal { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
