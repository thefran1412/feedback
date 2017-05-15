using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;

public partial class Template : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Logo.ServerClick += new System.EventHandler(this.Logo_Click);
        
    }

    public void Logo_Click(object sender, EventArgs e)
    {
        if (Session["userId"] != null)
        {
            string url = "/folder/index/" + Session["userId"];
            // routes.Redirect("uk", "/uk/Home/Index");
            Response.Redirect(url);
        }
        else
        {
            Response.Redirect("/");
        }
    }
}
