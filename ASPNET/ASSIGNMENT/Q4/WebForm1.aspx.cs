using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label1.Text = "page loaded for the first time" ;
            }
            else
            {
                Label1.Text = "this is a postback request";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}