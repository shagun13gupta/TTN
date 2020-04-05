
using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            UserDBContext context = new UserDBContext();
            List<Employee> emp = context.Employees.ToList();
            return View(emp);
        }

        public ActionResult Search(string search)
        {
            UserDBContext context = new UserDBContext();
            var emp = context.Employees.Where(x => x.Name.Contains(search)).ToList();
            return View(emp);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            UserDBContext context = new UserDBContext();
            if (employee != null)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return View(employee);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            UserDBContext context = new UserDBContext();
            
            var emp = context.Employees.FirstOrDefault(s => s.Id == id);
            

            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            using (UserDBContext context = new UserDBContext())
            {
                context.Entry(employee).State = EntityState.Modified;
                context.SaveChanges();
            }              
            return View();
            
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            UserDBContext context = new UserDBContext();
          

            var emp = context.Employees.Where(s => s.Id == id).FirstOrDefault();


            return View(emp);
        }
        [HttpPost]
        public ActionResult Delete(int id,Employee employee)
        {
            using (UserDBContext context = new UserDBContext())
            {
                employee = context.Employees.Where(s => s.Id == id).FirstOrDefault();
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return View();

        }
    }
}
