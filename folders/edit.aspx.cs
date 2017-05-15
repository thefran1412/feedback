using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using crud;

public partial class folders_edit : System.Web.UI.Page
{
    string hash = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        hash = Page.RouteData.Values["hash"].ToString();

        Folders folder = new Folders();
        DataSet ds = folder.getInfo(hash);

        var data = ds.Tables[0].Rows[0];
        if (!Page.IsPostBack)
        {
            name.Text = data.ItemArray[1].ToString();
            color1.Text = data.ItemArray[2].ToString();
            color2.Text = data.ItemArray[3].ToString();
        }
    }
    protected void Edit(object sender, EventArgs e)
    {
        Folders folder = new Folders();
        folder.edit(name.Text, color1.Text, color2.Text, hash);
        Response.Redirect("/folder/index/");
    }
}