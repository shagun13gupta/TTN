using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Q8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("shagun");
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into login(uname,pass)values(@uname,@pass)", sqlConnection);
                command.Parameters.AddWithValue("@uname", TextBox3.Text);
                command.Parameters.AddWithValue("@pass", TextBox4.Text);

                command.ExecuteNonQuery();
                Label1.Text = "Data inserted";
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}