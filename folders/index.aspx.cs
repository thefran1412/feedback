using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using db;
using per;

public partial class entity_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // getting variable from url
        var id = Session["userId"];
        var query = "";

        // first query
        query = "SELECT * FROM users WHERE id = " + id + ";";
        Base conn = new Base();
        DataSet first = conn.getData(query);

        // if there's an entry stay in page and continue, else go to page before this
        Permissions p = new Permissions();
        p.set(first.Tables[0].Rows.Count);

        // second query
        query = "SELECT f.* FROM users_folders uf, folders f WHERE uf.folder_id = f.id AND uf.user_id = " + id + ";";
        DataSet second = conn.getData(query);

        // send data to the repeater
        Repeater1.DataSource = second;
        Repeater1.DataBind();
    }
}