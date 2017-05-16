using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Permissions p = new Permissions();
        p.set();

    }

    protected void Create(object sender, EventArgs e)
    {
        Folders folder = new Folders();
        folder.add(name.Text, color1.Text, color2.Text);
        Response.Redirect("/folder/index/");
    }

}