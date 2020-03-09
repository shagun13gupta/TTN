using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CRUD.DATA;

namespace CRUD.Controllers
{
    public class StudentController : ApiController
    {
        Models.Student student = new Models.Student();
        DATA.StudentData studentData = new StudentData();



        [HttpGet]
        public IHttpActionResult GetData()
        {
            DataSet ds = studentData.GetData();
            return Ok(ds);
        }

        [HttpGet]
        public IHttpActionResult GetData(int id)
        {
            DataSet ds = studentData.GetData(id);
            return Ok(ds);
        }

        [HttpPost]
        public IHttpActionResult InsertDAta(Models.Student student)
        {
            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }

                bool result = studentData.InsertDAta(student);
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

        public IHttpActionResult UpdateData(int id, [FromBody]Models.Student student)
        {
            //Student student = new Student();
            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }
                bool result = studentData.UpdateData(id, student);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "unable to update data" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        [HttpDelete]
        public IHttpActionResult DeleteData(int id)
        {

            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }
                bool result = studentData.DeleteData(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Something went wrong" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
