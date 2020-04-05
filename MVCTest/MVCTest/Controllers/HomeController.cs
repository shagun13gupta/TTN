using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(Login login)
        {
            using(UserDBContext context=new UserDBContext())
            {
                ModelState.Clear();
                var details = context.Logins.Where(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();
                if(details==null)
                {
                    login.ErrorMessage = "Wrong Username and password";
                    return View("Login", login);
                }
                else
                {
                    Session["Id"] = login.Id;
                    Session["username"] = login.UserName;                    
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }
    }
}