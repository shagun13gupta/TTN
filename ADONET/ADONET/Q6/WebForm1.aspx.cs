using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Q6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ConnectionString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        private void GetData()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("select EMP_ID, EMP_NAME,SALARY from EMPLOYEE", sqlConnection);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    GridView2.DataSource = dataReader;
                    GridView2.DataBind();
                }
            }
               
        }
      

        protected void Button1_Click1(object sender, EventArgs e)
        {

            ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlTransaction transaction = sqlConnection.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("update EMPLOYEE set SALARY=SALARY-1000 where EMP_ID=100", sqlConnection, transaction);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("update EMPLOYEE set SALARY=SALARY+1000 where EMP_ID=101", sqlConnection, transaction);
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    Label1.Text = "transaction completed";


                }
                catch
                {
                    transaction.Rollback();
                    Label1.Text = "transaction rolled back";
                }
            }
            GetData();
        }
    }
}