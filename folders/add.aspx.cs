using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crud;

public partial class folders_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Permissions p = new Permissions();
        p.set(1);

    }

    protected void Create(object sender, EventArgs e)
    {
        Folders folder = new Folders();
        folder.add(name.Text, color1.Text, color2.Text);
        Response.Redirect("/folder/index/");
    }

}