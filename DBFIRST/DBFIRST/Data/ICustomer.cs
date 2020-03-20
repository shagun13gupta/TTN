using DBFIRST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBFIRST.Data
{
    public interface ICustomer
    {
        public IEnumerable<Customer> GetData();
        public bool InsertData(Customer customer);
        public bool DeleteCustId(Orders orders);

        public bool UpdateData(string id, Orders orders);
      

    }
}
