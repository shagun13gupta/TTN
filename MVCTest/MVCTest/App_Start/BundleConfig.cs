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

            bundelCollection.Add(new ScriptBundle("~/bundle/css_Login")
                .Include("~/Content/Template/css/MyLogin.css",
                "~/Content/Template/css/font-awesome.min.css",
                "~/Content/Template/css/bootstrap.min.css"));

            bundelCollection.Add(new ScriptBundle("~/bundle/script_Login")
                 .Include("~/Content/Template/js/jquery.min.js",
                   "~/Content/Template/js/bootstrap.min.js"));

            bundelCollection.Add(new ScriptBundle("~/bundle/script_Table")
                 .Include("~/Content/Template/js/jquery.min.js",
                   "~/Content/Template/js/bootstrap.min.js",
                   "~/Content/Template/js/MyJS.js"

                   ));
            bundelCollection.Add(new StyleBundle("~/bundle/css_Table")
                  .Include("~/Content/Template/css/bootstrap.min.css",
                      "~/Content/Template/css/font-awesome.min.css",
                        "~/Content/Template/css/MyStyleSheet1.css"


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