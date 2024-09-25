using System;
using System.Data;

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
        // Sample data source. Replace this with your actual data source.
        DataTable dt = new DataTable();
        dt.Columns.Add("Column1");
        dt.Columns.Add("Column2");
        dt.Columns.Add("Column3");

        // Add sample data to the DataTable
        for (int i = 0; i < 100; i++)
        {
            dt.Rows.Add("Data " + i, "Data " + (i + 1), "Data " + (i + 2));
        }

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}
