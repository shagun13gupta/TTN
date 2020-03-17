using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jwt.Data;
using Jwt.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IStudent _data;
        public IndexController(IStudent data)
        {

            _data = data;
        }

        [Authorize(Roles ="admin")]
        [HttpGet]
        public IActionResult GetData()
        {
            IEnumerable<Student> s = _data.GetData();
            return Ok(s);
        }

        [Authorize(Roles ="shagun")]
        [HttpGet("{id}")]

        public IActionResult GetDataById(int id)
        {
            Student s = _data.GetDataById(id);
            return Ok(s);
        }

        [Authorize(Roles ="admin")]
        [HttpPost]
        public IActionResult InsertData(Student student)
        {
            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.InsertData(student);
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

        [Authorize(Roles ="shagun")]
        [HttpPut("{id}")]
        public IActionResult UpdateData(int id,Student student)
        {
            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.UpdateData(id,student);
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

        [Authorize(Roles ="admin")]
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            Student student = new Student();
            try
            {
                if (student == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.DeleteData(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Id not found..........!!!" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}