using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class folders_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var hash = Page.RouteData.Values["hash"].ToString();

        Permissions p = new Permissions();
        p.set();

        Folders folder = new Folders();
        folder.delete(hash);
        Response.Redirect("/folder/index/");
    }
}