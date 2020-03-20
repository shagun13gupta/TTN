  using DBFIRST.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBFIRST.Data
{
    public class CustomerClass:ICustomer
    {
        public bool DeleteCustId(Orders orders)
        {
            try
            {
                using (var context = new TestContext())
                {
                    var std = context.Customer.FirstOrDefault(s => s.CustomerId == orders.CustomerId);
                    context.Customer.Remove(std);
                    var std1 = context.Orders.FirstOrDefault(s => s.OrderId == orders.OrderId);
                    context.Orders.Remove(std1);
                    var std2 = context.Product.FirstOrDefault(s => s.ProductId == orders.ProductId);
                    context.Product.Remove(std2);
                    context.SaveChanges();

                  
                    return true;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
        public IEnumerable<Customer> GetData()
        {
            var context = new TestContext();
          
            var result = context.Customer.Include(s => s.Orders).ToList();
            return result;
                   
        }

        public bool InsertData(Customer customer)
        {
            var context = new TestContext();
            try
            {

                context.Customer.Add(customer);
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateData(string id, Orders orders)
        {
            try
            {
                using (var context = new TestContext())
                {


                    var std1 = context.Orders.Include(o => o.Customer).Include(p => p.Product).FirstOrDefault(s => s.OrderId == id);

                    std1.Customer.CustomerId = orders.CustomerId;
                    std1.Product.ProductId = orders.ProductId;

                    std1.OrderId = orders.OrderId;


                    context.Entry(std1).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;





                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
