using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CODEFIRST.Models
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}