using CODEFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CODEFIRST.Data
{
    public interface Icustomer
    {
        IEnumerable<Models.Customer> GetData();
        Models.Customer GetDataById(int id);
        bool InsertData(Models.Customer customer);
        bool DeleteCustId(Orders orders);

        bool UpdateData(string id, Orders orders);
    }
}