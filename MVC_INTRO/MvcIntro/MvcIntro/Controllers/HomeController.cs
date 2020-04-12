using MvcIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcIntro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "shagun",
                Age = 22
            };
            TempData["data"] = student;
        
            ViewBag.Message = "Data coming from controller to view using ViewBag";
            var students = new List<string>
            {
                "Shagun Gupta",
                "Gaurav Gupta",
                "Ruchi Aggrawal"
            };
            ViewBag.Students = students;
            return View();
        }
        public ActionResult Ques1()
        {
            return View();
        }
        public ActionResult Ques2()
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

        [HttpPost]
        public string PostParameter(string firstname,string lastname)
        {
            return "Values using Parameters are .......  " + firstname + "," + lastname;
        }

        [HttpPost]
        public string PostRequest()
        {
            string firstname = Request["firstname"];
            string lastname = Request["LastName"];
            return "Values using Request are .......  " + firstname + "," + lastname;
        }

        [HttpPost]
        public string PostFormCollection(FormCollection formCollection)
        {
            string firstname = formCollection["firstname"];
            string lastname = formCollection["LastName"];
            return "Values using formCollection are .......  " + firstname + "," + lastname;
        }

        [HttpPost]
        public string PostUsingBinding(Student student)
        {
            return "Values using Binding are .......  " +student.Id + "," + student.Name + "," +student.Age;
        }
    }
}