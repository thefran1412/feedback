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

public partial class entity_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // getting variable from url
        var hash = Page.RouteData.Values["hash"];
        var query = "";

        // does element exist?
        query = "SELECT * FROM folders WHERE hash = '" + hash + "'";
        Base conn = new Base();
        DataSet first = conn.getData(query);

        // does user have permission to enter?
        query = "SELECT u.user_id FROM users_folders u, folders f WHERE u.folder_id = f.id AND f.hash = '"+hash+"'";
        DataSet user = conn.getData(query);
        var user_data = user.Tables[0].Rows[0];

        // if there's an entry stay in page and continue, else go to page before this
        Permissions p = new Permissions();
        p.set(first.Tables[0].Rows.Count, Request.Url.ToString(), user_data.ItemArray[0].ToString());
        
        // get objects
        query = "SELECT fo.* FROM folders f, forms fo WHERE f.id = fo.folder_id AND f.hash = '" + hash + "'";
        DataSet second = conn.getData(query);

        // send objects data to the repeater
        Repeater1.DataSource = second;
        Repeater1.DataBind();
    }
}