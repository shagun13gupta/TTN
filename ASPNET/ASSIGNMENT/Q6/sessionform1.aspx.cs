using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q6
{
    public partial class sessionform1 : System.Web.UI.Page//
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["name"].ToString();
            TextBox2.Text = Session["password"].ToString(); 

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["password"] = TextBox2.Text;
        }
    }
}