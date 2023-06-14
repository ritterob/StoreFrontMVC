using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class User
    {
        public User()
        {
            OrderCustomers = new HashSet<Order>();
            OrderEmployees = new HashSet<Order>();
        }

        public string UserId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string UserZip { get; set; } = null!;
        public string? UserPhone { get; set; }
        public string? UserEmail { get; set; }

        public virtual ICollection<Order> OrderCustomers { get; set; }
        public virtual ICollection<Order> OrderEmployees { get; set; }
    }
}
