using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CODEFIRST.Models
{
    public class Orders
    {
        [Key]
        public string OrderId { get; set; }
        public int Quantity { get; set; }
        public string ProductId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}