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
    public partial class EditLunch : Page
    {
        
        private String connString = WebConfigurationManager.ConnectionStrings["lunchesDB"].ToString();
        private String id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                id = Request.Params["id"];

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = $"SELECT * FROM lunch WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        txtFirstName.Text = reader[1].ToString();
                        txtFirstName.Enabled = false; 
                        txtLastName.Enabled = false;
                        txtLastName.Text = reader[2].ToString();
                        ddlProgram.SelectedValue = reader[3].ToString();
                        ddlStarch.SelectedValue = reader[4].ToString();
                        ddlMeat.SelectedValue = reader[5].ToString();
                        ddlSideDish.SelectedValue = reader[6].ToString();
                        ddlBeverage.SelectedValue = reader[7].ToString();


                    }
                }
            }

        }

        protected void btnAddLunch_Click(object sender, EventArgs e)
        {

        }

        protected void btnEditLunch_Click(object sender, EventArgs e)
        {
            string program = ddlProgram.SelectedValue;
            string starch = ddlStarch.SelectedValue;
            string meat = ddlMeat.SelectedValue;
            string sideDish = ddlSideDish.SelectedValue;
            string beverage = ddlBeverage.SelectedValue;
            String lunchId = Request.Params["id"];

            string query = "UPDATE lunch SET program = @Program, starch = @Starch, meat = @Meat, sideDish = @SideDish, beverage = @Beverage WHERE id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Program", program);
                    cmd.Parameters.AddWithValue("@Starch", starch);
                    cmd.Parameters.AddWithValue("@Meat", meat);
                    cmd.Parameters.AddWithValue("@SideDish", sideDish);
                    cmd.Parameters.AddWithValue("@Beverage", beverage);
                    cmd.Parameters.AddWithValue("@Id", lunchId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Update successful
                        lblInfo.Text = "Lunch data updated successfully.";
                    }
                    else
                    {
                        // No rows affected, update failed
                        lblInfo.Text = "Failed to update lunch data.";
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