using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.RouteData.Values["hash"] == null)
        {
            Permissions.goBack();
        }
        var hash = Page.RouteData.Values["hash"].ToString();

        Permissions p = new Permissions();
        p.set();

        Forms form = new Forms();
        form.delete(hash);
        Response.Redirect("/folder/index/");
    }
}