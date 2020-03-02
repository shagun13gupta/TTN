using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q6
{
    public partial class ApplicationForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Application["name"].ToString();
            TextBox2.Text = Application["password"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Application["name"] = TextBox1.Text;
            Application["password"] = TextBox2.Text;
        }
    }
}