using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*DataBase obj = new DataBase();
        obj.getData("select * from users");
        Repeater1.DataSource() = obj;
        Repeater1.DataBind();

        var adios = hola.Tables["dades"];*/
        //ViewState["GoBackTo"] = Request.UrlReferrer;

        //if(Session["userId"].ToString() != "")
        //{
        //    Response.Redirect("/folder/index");
        //}
        //Session["url"] = Request.Url.ToString();
        if (Session["userId"] != null && Session["userId"].ToString() != "")
        {
            Response.Redirect("/folder/index");
        }
        Session["url"] = Request.Url.ToString();


        if (Page.RouteData.Values["hash"] == null)
        {
            Permissions.goBack();
        }

        // getting variable from url
        var hash = Page.RouteData.Values["hash"].ToString();
        add_new.HRef = "/form/add/" + hash;
        edit.HRef = "/folder/edit/" + hash;
        delete.HRef = "/folder/delete/" + hash;
        // if there's an entry stay in page and continue, else go to page before this
        Permissions p = new Permissions();
        p.set();

        // get objects
        Folders folder = new Folders();
        DataSet ds = folder.getForms(hash);

        // send objects data to the repeater
        Repeater1.DataSource = ds;
        Repeater1.DataBind();
    }
}