using MvcAdvance.Filters;
using MvcAdvance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAdvance.Controllers
{
    [RoutePrefix("employees")]
    public class EmployeeController : Controller
    {
        // GET: Employee
        
            
        [CustomException]     //this is a custom exception using IException Filter used in Filters Folder
        public  ActionResult Index()
        {
            return View("test");
        }

        [HandleError]      //this a predefined filter of mvc for handling the exception 
        public ActionResult About()
        {
            throw new Exception("This is an Exception");
        }

        [CustomAuthenticationFilter]               /*it is a custom authentication filter using IAuthenticationFilter such that you
                                                    cannot view the details until you will login .*/
        [OutputCache(Duration =10,Order =2)]
      
        public ActionResult Details()
        {
            try
            {
                UserDBContext context = new UserDBContext();
                List<Employee> emp = context.Employees.ToList();
                return View(emp);
            }
            catch(Exception) 
            {

                throw new Exception("This is an Exception");
            }
        }

        [HttpGet]
        [OutputCache(Duration = 10, Order = 2)]      //it is a prefined output cache filter 
        [HandleError(Order = 1)]
        [Route("{id}")]            //it is a attribute routing
        [Route("{id}/Details")]
        public ActionResult GetById(int id)
        {
            try
            {
                UserDBContext context = new UserDBContext();
                var result = context.Employees.Where(s => s.Id == id).FirstOrDefault();
                return View(result);
            }
            catch (Exception)
            {

                throw new Exception("This is an Exception");
            }
        }

        [HttpGet]        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]    
        [ValidateAntiForgeryToken]      //ValidateAntiForgeryToken attribute is to prevent cross-site request forgery attacks.
        public ActionResult Create(Employee employee)
        {
            UserDBContext context = new UserDBContext();
            if (ModelState.IsValid)
            {
                try
                {
                    if (employee != null)
                    {
                        context.Employees.Add(employee);
                        context.SaveChanges();
                        return View();
                    }
                }
                catch
                {
                    return RedirectToAction("Details", "Employee");
                }
            }

            return View("Create", employee);


        }
    }
}