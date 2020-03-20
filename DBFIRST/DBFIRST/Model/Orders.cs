using System;
using System.Collections.Generic;

namespace DBFIRST.Model
{
    public partial class Orders
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
