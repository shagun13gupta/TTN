using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("QUES 3: Create sample program to implement all the sqlcommands viz. ExecuteReader, ExecuteNonQuery and ExecuteScalar<br/><br/>");
           
            
            //QUES 10 handle the connection properly and descibe the various ways to handle the database connection.

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("select * from test", sqlConnection);
                    GridView1.DataSource = command.ExecuteReader();
                    GridView1.DataBind();
                    sqlConnection.Close();
                    Response.Write("<br/><br/><br/><br/>");
                    sqlConnection.Open();

                    SqlCommand command2 = new SqlCommand("select count(name) from test", sqlConnection);
                    int result = (int)command2.ExecuteScalar();
                    Response.Write("total students are=" + result.ToString());
                    Response.Write("<br/><br/><br/><br/>");
                    sqlConnection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<br/><br/><br/><br/>");
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    SqlCommand command1 = new SqlCommand("insert into test(name,age,city) values(@name,@age,@city)", sqlConnection);
                    command1.Parameters.AddWithValue("@name", TextBox1.Text);
                    command1.Parameters.AddWithValue("@age", TextBox2.Text);
                    command1.Parameters.AddWithValue("@city", TextBox3.Text);
                    command1.ExecuteNonQuery();
                    Label4.Text = "Data inserted successfully";
                    sqlConnection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}