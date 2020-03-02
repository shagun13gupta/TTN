using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Q_9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //QUES 7: (DONE HERE BUTTON CLICK EVENT) Create a program to handle Button related events(use database to store data) :
            //Ques 10: done in this part

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();


                    SqlCommand command = new SqlCommand("insert into student(fname,lname,gen,age,email,addresses,phoneno,pass)values(@fname,@lname,@gen,@age,@email,@addresses,@phoneno,@pass)", sqlConnection);
                    command.Parameters.AddWithValue("@fname", TextBox1.Text);
                    command.Parameters.AddWithValue("@lname", TextBox2.Text);
                    command.Parameters.AddWithValue("@gen", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@age", TextBox8.Text);
                    command.Parameters.AddWithValue("@email", TextBox3.Text);
                    command.Parameters.AddWithValue("@addresses", TextBox4.Text);
                    command.Parameters.AddWithValue("@phoneno", TextBox5.Text);
                    command.Parameters.AddWithValue("@pass", TextBox6.Text);
                    command.ExecuteNonQuery();
                    Label1.Text = "Data Inserted Successfully";
                    sqlConnection.Close();
                }
            }
            catch (Exception)
            {

                Label1.Text = "Something Wrong with the connectivity";
            }
            finally
            {
                Response.Write("finally block executed........");
            }
                      
        }

        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            switch(e.CommandName)
            {
                case "firstbutton":
                    Label2.Text = "clicked first button";                    
                    break;
                case "secondbutton":
                    Label3.Text = "   Clicked second button   ";                    
                    break;
                case "thirdbutton":
                    Label4.Text = "clicked third button";
                    
                    break;

            }

        }
    }
}