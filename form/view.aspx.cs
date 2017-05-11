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

public partial class form_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // getting variable from url
        var hash = Page.RouteData.Values["hash"];
        var query = "";

        // first query
        query = "SELECT * FROM forms WHERE hash = '" + hash + "'";
        Base conn = new Base();
        DataSet first = conn.getData(query);

        // if there's an entry stay in page and continue, else go to page before this
        Permissions p = new Permissions();
        p.set(first.Tables[0].Rows.Count, Request.Url.ToString());

        // set info to variable
        var data = first.Tables[0].Rows[0].ItemArray;
        name.Text = data[2].ToString();

 
    }
}