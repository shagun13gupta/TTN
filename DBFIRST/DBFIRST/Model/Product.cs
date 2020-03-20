using System;
using System.Collections.Generic;

namespace DBFIRST.Model
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Orders>();
        }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
