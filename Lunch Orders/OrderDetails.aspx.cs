using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lunch_Orders
{
    public partial class OrderDetails : Page
    {
        private String connString = WebConfigurationManager.ConnectionStrings["lunchesDB"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = $"SELECT * FROM lunch WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        GridView1.DataSource = reader;
                        GridView1.DataBind();
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            lblPerson.Text = $" {reader[1]} {reader[2]}";
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                lblPerson.Text = ex.Message;
            }

        }
    }
}