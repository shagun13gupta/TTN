using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Q7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ConnectionString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] == null)
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter dataAdapter=new SqlDataAdapter("select * from salary",sqlConnection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    GridView1.DataSource = dataSet;
                    GridView1.DataBind();

                    Cache["Data"] = dataSet;
                    Label1.Text = "Data is loaded from the database";
                }
            }
            else
            {
                GridView2.DataSource = (DataSet)Cache["Data"];
                GridView2.DataBind();
                Label1.Text = "data loaded from the cache";
            }
        }
    }
} 