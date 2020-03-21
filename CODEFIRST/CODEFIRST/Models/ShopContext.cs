using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CODEFIRST.Models
{
    public class ShopContext:DbContext
    {
        public ShopContext() : base("ShopContext") { }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
    }
}