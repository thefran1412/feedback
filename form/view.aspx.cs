﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class form_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var hash = Page.RouteData.Values["hash"];
        if (hash == null)
        {
            Response.Redirect("/folder/index/1");
        }
        var query = "SELECT fo.* FROM forms fo WHERE fo.hash = '" + hash + "'";

        SqlConnection con = new SqlConnection("Data Source=serverfeedback.database.windows.net; Initial Catalog=feedback; Persist Security Info=True; User ID=admin123; Password=piZzarra1617;");
        SqlDataAdapter sda = new SqlDataAdapter(query, con);

        DataSet ds = new DataSet();

        sda.Fill(ds, "reg");

        var data = ds.Tables[0].Rows[0].ItemArray;
        name.Text = data[2].ToString();

        if (ds.Tables[0].Rows.Count > 0)
        {
             //object hol = ds.Tables[0].Rows[0].ItemArray;
        }

 
    }
}