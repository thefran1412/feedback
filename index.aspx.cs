using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using db;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["url"] = Request.Url.ToString();

        var query = "SELECT * FROM forms WHERE visible = 1";
        Base db = new Base();
        DataSet ds = db.getData(query);

        // send objects data to the repeater
        Repeater1.DataSource = ds;
        Repeater1.DataBind();
    }
}