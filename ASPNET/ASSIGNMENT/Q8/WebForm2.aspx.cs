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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label2.Text = "page loaded for the first time";
            }
            else
            {
                Label2.Text = "this is a postback request";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into register(fname,lname,gen,email,addresses,phoneno)values(@fname,@lname,@gen,@email,@addresses,@phoneno)", sqlConnection);
                command.Parameters.AddWithValue("@fname", TextBox1.Text);
                command.Parameters.AddWithValue("@lname", TextBox2.Text);
                command.Parameters.AddWithValue("@gen", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@email", TextBox3.Text);
                command.Parameters.AddWithValue("@addresses", TextBox4.Text);
                command.Parameters.AddWithValue("@phoneno", TextBox5.Text); ;
                command.ExecuteNonQuery();
                Label1.Text = "Data inserted";
            }

        }
    }
}