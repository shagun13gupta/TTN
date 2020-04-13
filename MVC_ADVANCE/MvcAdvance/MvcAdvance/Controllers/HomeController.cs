using MvcAdvance.Filters;
using MvcAdvance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcAdvance.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      
        
        public ActionResult Index()
        {                     
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