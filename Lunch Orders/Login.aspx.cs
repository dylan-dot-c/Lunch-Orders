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
    public partial class Login : Page
    {
        private String connString = WebConfigurationManager.ConnectionStrings["lunchesDB"].ToString();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using(SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM login WHERE username = @username AND password = @password";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        Session["Username"] = reader["username"];
                        Session["Id"] = reader["Id"];

                        Response.Redirect("~/Lunches.aspx");
                    }else
                    {
                        lblError.Text = "Incorrect Login Credentials";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
            }
        }
    }
}