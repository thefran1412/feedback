using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class entity_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // creating sql connection
        SqlConnection con = new SqlConnection("Data Source=serverfeedback.database.windows.net; Initial Catalog=feedback; Persist Security Info=True; User ID=admin123; Password=piZzarra1617;");

        // getting variable from url
        var id = Page.RouteData.Values["id"];
        var query = "";
        // first query
        query = "SELECT * FROM users WHERE id = " + Page.RouteData.Values["id"];
        SqlDataAdapter sdaf = new SqlDataAdapter(query, con);
        DataSet first = new DataSet();
        sdaf.Fill(first);

        // if there's an entry stay in page and continue, else go to page before this
        if (first.Tables[0].Rows.Count <= 0)
        {
            if (Session["url"] == null)
            {
                Response.Redirect("/");
            }
            else
            {
                Response.Redirect(Session["url"].ToString());
            }
        }
        Session["url"] = Request.Url.ToString();

        // second query
        query = "SELECT f.* FROM users_folders uf, folders f WHERE uf.folder_id = f.id AND uf.user_id = " + Page.RouteData.Values["id"];
        SqlDataAdapter sdas = new SqlDataAdapter(query, con);
        DataSet second = new DataSet();
        sdas.Fill(second);
        
        // send data to the repeater
        Repeater1.DataSource = second;
        Repeater1.DataBind();

    }
}