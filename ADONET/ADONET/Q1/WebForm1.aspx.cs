using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("QUES 1: Describe all the data provider objects with sample code");

            string ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("select * from employee; select * from student ", sqlConnection);
                using(SqlDataReader reader=command.ExecuteReader())
                {
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    while(reader.NextResult())
                    {
                        GridView2.DataSource = reader;
                        GridView2.DataBind();
                    }
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter("proc1", sqlConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                GridView3.DataSource = dataSet;
                GridView3.DataBind();
            }
        }
    }
}