using CODEFIRST.Data;
using CODEFIRST.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace CODEFIRST.Controllers
{
    public class IndexController : ApiController
    {
        



        Data.Customer _customer = new Data.Customer();
        Models.Customer customer = new Models.Customer();
        Orders orders = new Orders();

        [HttpGet]
        public IHttpActionResult GetData()
        {
            var result = _customer.GetData();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetDataById(int id)
        {


            var result = _customer.GetDataById(id);
            return Ok(result);


        }
        [HttpPost]
        public IHttpActionResult InsertData(Models.Customer customer)
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

        [HttpPut]
        public IHttpActionResult UpdateData(string id, Orders orders)
        {

            Data.Customer customer = new Data.Customer();
            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.UpdateData(id, orders);
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
        public IHttpActionResult DeleteCustId(Orders orders)
        {
            Data.Customer customer = new Data.Customer();
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
