using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAdvance.Filters
{
    public class CustomAction :ActionFilterAttribute
    {
          public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("hello this is action filter");
            filterContext.Result = new RedirectResult("/Employee/Details");
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
        }
    }
}