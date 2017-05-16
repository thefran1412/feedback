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
    }
}