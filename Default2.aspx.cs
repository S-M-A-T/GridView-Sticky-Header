using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }
    }

    private void BindGrid()
    {
        // Get the connection string from the Web.config file
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        // Create a SqlConnection and SqlCommand
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            // SQL query to retrieve data from your table
            string query = "SELECT Column1, Column2, Column3 FROM SampleTable"; // Adjust this query to match your database schema
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                conn.Open(); // Open the database connection
                da.Fill(dt); // Fill the DataTable with the data from the database
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., log the error)
                Console.WriteLine("Error: " + ex.Message);
            }

            // Bind the DataTable to the GridView
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
