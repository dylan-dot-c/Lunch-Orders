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
    public partial class AddLunch : Page
    {
        private String connString = WebConfigurationManager.ConnectionStrings["lunchesDB"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if user is logged in

            if (Session["Username"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnAddLunch_Click(object sender, EventArgs e)
        {
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;
            String program = ddlProgram.SelectedValue;
            String starch = ddlStarch.SelectedValue;
            String meat = ddlMeat.SelectedValue;
            String sideDish = ddlSideDish.SelectedValue;
            String beverage = ddlBeverage.SelectedValue;
            String date = txtDate.Text;

            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO lunch (first_name, last_name, program, starch, meat, sidedish, beverage, date) VALUES (@FirstName, @LastName, @Program, @Starch, @Meat, @SideDish, @Beverage, @Date)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters and their values
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Program", program);
                        cmd.Parameters.AddWithValue("@Starch", starch);
                        cmd.Parameters.AddWithValue("@Meat", meat);
                        cmd.Parameters.AddWithValue("@SideDish", sideDish);
                        cmd.Parameters.AddWithValue("@Beverage", beverage);
                        cmd.Parameters.AddWithValue("@Date", date);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Insert successful
                            lblInfo.Text = "New Lunch Order Added Successfully.";
                            txtFirstName.Text = "";
                            txtLastName.Text = "";
                            ddlProgram.SelectedValue = "";
                            ddlStarch.SelectedValue = "";
                            ddlMeat.SelectedValue = "";
                            ddlSideDish.SelectedValue = "";
                            ddlBeverage.SelectedValue = "";
                            txtDate.Text = "";
                        }
                        else
                        {
                            // Insert failed
                            lblInfo.Text = "Failed to add Lunch Order";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }
    }
}