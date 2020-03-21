using CODEFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace CODEFIRST.Data
{
    public class Customer:Icustomer
    {
        public bool DeleteCustId(Orders orders)
        {
            try
            {
                using (var context = new ShopContext())
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


        public IEnumerable<Models.Customer> GetData()
        {
                var context = new ShopContext();

            var res = context.Customer.Include(s => s.Orders).ToList();
            return res;

        }

        public Models.Customer GetDataById(int id)
        {

            var context = new ShopContext();
           

            var list = context.Customer.Where(c => c.CustomerId == id).Include(s => s.Orders).ThenInclude(s => s.Product).FirstOrDefault();

            return list;
        }

        public bool InsertData(Models.Customer customer)
        {
            var context = new ShopContext();
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
                using (var context = new ShopContext())
                {


                    var std1 = context.Orders.Include(o => o.Customer).Include(p => p.Product).FirstOrDefault(s => s.OrderId == id);

                    std1.Customer.CustomerId = orders.CustomerId;
                    std1.Quantity = orders.Quantity;
                    std1.Product.ProductId = orders.ProductId;

                    std1.OrderId = orders.OrderId;


                    context.Entry(std1).State = System.Data.Entity.EntityState.Modified;
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