using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using db;

public partial class entity_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if there's an entry stay in page and continue, else go to page before this
        Permissions p = new Permissions();
        p.set();

        // getting variable from url
        var id = Session["userId"].ToString();
        var query = "";

        // second query
        query = "SELECT f.* FROM users_folders uf, folders f WHERE uf.folder_id = f.id AND uf.user_id = " + id + ";";
        Base conn = new Base();
        DataSet second = conn.getData(query);

        // send data to the repeater
        Repeater1.DataSource = second;
        Repeater1.DataBind();
    }
}