using System;
using System.Collections.Generic;

namespace DBFIRST.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNo { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
