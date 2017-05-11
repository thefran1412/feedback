using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class entity_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var hash = Page.RouteData.Values["hash"];
        if (hash == null)
        {
            Response.Redirect("/folder/index/1");
        }
        var query = "SELECT fo.* FROM folders f, forms fo WHERE f.id = fo.folder_id AND f.hash = '" + hash + "'";

        SqlConnection con = new SqlConnection("Data Source=serverfeedback.database.windows.net; Initial Catalog=feedback; Persist Security Info=True; User ID=admin123; Password=piZzarra1617;");
        SqlDataAdapter sda = new SqlDataAdapter(query, con);

        DataTable dt = new DataTable();

        sda.Fill(dt);
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
    }
}