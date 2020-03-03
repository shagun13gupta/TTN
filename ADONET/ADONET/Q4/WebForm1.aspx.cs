using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ConnectionString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("QUES 4: What are the two architecure in ado .net for connection create a connection, implement both architecure and show the difference<br/><br/>");


            //QUES 10 handle the connection properly and descibe the various ways to handle the database connection.

            ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("select * from employee; select * from student ", sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    while (reader.NextResult())
                    {
                        GridView2.DataSource = reader;
                        GridView2.DataBind();
                    }
                }
                sqlConnection.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("proc1", sqlConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                GridView3.DataSource = dataSet.Tables[0];
                GridView3.DataBind();
            }
        }
    }
}