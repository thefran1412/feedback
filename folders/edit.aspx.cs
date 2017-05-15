using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crud;
using per;

public partial class folders_edit : System.Web.UI.Page
{
    string hash = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        hash = Page.RouteData.Values["hash"].ToString();
    }
    protected void Edit(object sender, EventArgs e)
    {
        Folders folder = new Folders();
        folder.edit(name.Text, color1.Text, color2.Text, hash);
        Response.Redirect("/folder/view/"+hash);
    }
}