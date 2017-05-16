using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class form_edit : System.Web.UI.Page
{
    string hash = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        hash = Page.RouteData.Values["hash"].ToString();

        Permissions p = new Permissions();
        p.set();

        Forms form = new Forms();
        DataSet ds = form.getInfo(hash);

        var data = ds.Tables[0].Rows[0];

        if (!Page.IsPostBack)
        {
            name.Text = data.ItemArray[2].ToString();
            color1.Text = data.ItemArray[4].ToString();
            color2.Text = data.ItemArray[5].ToString();
        }
    }
    protected void Edit(object sender, EventArgs e)
    {
        Forms form = new Forms();
        form.edit(name.Text, color1.Text, color2.Text, hash);
        Response.Redirect("/form/view/" + hash);
    }
}