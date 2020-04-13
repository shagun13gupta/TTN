using MvcAdvance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcAdvance.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            using (UserDBContext context = new UserDBContext())
            {
                bool Isvalid = context.Logins.Any(x => x.UserName == login.UserName && x.Password == login.Password);
                if (Isvalid)
                {
                    FormsAuthentication.SetAuthCookie(login.UserName, false);
                    return RedirectToAction("Details", "Employee");
                }
                return View("Error");
            }
        }
    }
}