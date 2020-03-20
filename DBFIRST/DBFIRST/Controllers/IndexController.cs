using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBFIRST.Data;
using DBFIRST.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DBFIRST.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        public readonly ICustomer _customer;
        public IndexController(ICustomer customer)
        {
            _customer = customer;
        }
        [HttpGet]
        public IActionResult GetData()
        {
            var result = _customer.GetData();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetData1(int id)
        {
          
            var context = new TestContext();

            var list = context.Customer.Where(c => c.CustomerId == id).Include(s => s.Orders).ThenInclude(s => s.Product).FirstOrDefault();
            return Ok(list);

            

        }
        [HttpPost]
        public IActionResult InsertData(Customer customer)
        {
            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.InsertData(customer);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

          
        }

        [HttpPut("{id}")]
        public IActionResult UpdateData(string id,Orders orders)
        {

            Customer customer = new Customer();
            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.UpdateData(id,orders);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to update data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpDelete]
        public IActionResult DeleteCustId(Orders orders)
        {
            Customer customer = new Customer();
            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.DeleteCustId(orders);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to delete data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        

    }
}