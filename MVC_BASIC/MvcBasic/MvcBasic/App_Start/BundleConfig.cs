using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCTest.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundelCollection)
        {
            bundelCollection.Add(new ScriptBundle("~/bundle/script")
                 .Include("~/Content/Template/js/jquery.min.js",
                    "~/Scripts/jquery-3.0.0.js",
                   "~/Content/Template/js/bootstrap.min.js",
                   "~/Content/Template/js/metisMenu.min.js",
                   "~/Content/Template/js/startmin.js"
                   
                   ));

         
            bundelCollection.Add(new StyleBundle("~/bundle/css")
                    .Include("~/Content/Template/css/bootstrap.min.css",
                        "~/Content/Template/css/font-awesome.min.css",
                         "~/Content/Template/css/metisMenu.min.css",
                          "~/Content/Template/css/startmin.css",
                          "~/Content/Template/css/MyStyleSheet1.css"


                  ));


        }
    }
}