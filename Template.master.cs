using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Configuration;

public partial class Template : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public void Logo_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Session["userId"] != null)
        {
            string url = "/folder/index/" + Session["userId"];
            //routes.Redirect("uk", "/uk/Home/Index");
            Response.Redirect(url);
            //myLink.Attributes["href"] = url;
        }
        else
        {
            //myLink.Attributes["href"] = "/";
        }

    }
}
