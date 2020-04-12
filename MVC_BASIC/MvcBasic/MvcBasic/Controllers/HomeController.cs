using MvcBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DetailsEmployee()
        {
            UserDBContext context = new UserDBContext();
            List<Employee> emp = context.Employee.ToList();
            return View(emp);
        }

        [HttpGet]
        public ActionResult DetailsLogin()
        {
            UserDBContext context = new UserDBContext();
            List<Login> logins = context.Login.ToList();
            return View(logins);
        }
        public ActionResult Ques2()
        {
            return View();
        }
        //[NonAction]:   If this method is named as [Non Action ] then its can be called as a URL request it will throw and error
        

        [ChildActionOnly]
        [HttpGet]
        public ActionResult EmployeeLogin()
        {
            Login login = new Login();
             
            return PartialView("EmployeeLogin",login);
        }

        [HttpPost]
        public ActionResult EmployeeLogin(Login login)
        {
            UserDBContext context = new UserDBContext();
            if (ModelState.IsValid)
            {
                try
                {
                    if (login != null)
                    {
                        context.Login.Add(login);
                        context.SaveChanges();
                        return View();
                    }
                }
                catch
                {
                    return RedirectToAction("DetailsLogin", "Home");
                }
            }

            return View("Index", login);


        }
        [ChildActionOnly]
        [HttpGet]
        public ActionResult EmployeeRegistration()
        {
            Employee employee = new Employee();
            return PartialView("EmployeeRegistration", employee);
        }

        [HttpPost]
        public ActionResult EmployeeRegistration([Bind(Include = "Id,Name,Age,Gender,Phone")]Employee employee)
        {
            UserDBContext context = new UserDBContext();
            if (ModelState.IsValid)
            {
                try
                {
                    if (employee != null)
                    {
                        context.Employee.Add(employee);
                        context.SaveChanges();
                        return View();
                    }
                }
                catch
                {
                    return RedirectToAction("DetailsEmployee", "Home");
                }
            }

            return View("Index", employee);


        }


        public ActionResult Ques3()
        {
            return View();
        }

        public ActionResult Ques4()
        {
            return View();
        }

        public ActionResult Ques5()
        {
            return View();
        }
    }
}