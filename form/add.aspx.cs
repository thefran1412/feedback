using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_add : System.Web.UI.Page
{
    string hash = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Permissions p = new Permissions();
        p.set();

        hash = Page.RouteData.Values["hash"].ToString();

    }

    protected void Create(object sender, EventArgs e)
    {
        Forms form = new Forms();
        form.add(name.Text, color1.Text, color2.Text, hash);
        Response.Redirect("/folder/view/"+hash);
    }

}