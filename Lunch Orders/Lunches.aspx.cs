using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lunch_Orders
{
    public partial class Lunches : Page
    {
        private String connString = WebConfigurationManager.ConnectionStrings["lunchesDB"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Username"] == null)
            {
                Response.Redirect("~/");
            }

            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT Id, first_name, last_name, program, date from lunch";

                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();

                }
            }

        }


    }
}