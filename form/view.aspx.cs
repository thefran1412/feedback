﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using db;

public partial class form_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.RouteData.Values["hash"] == null)
        {
            Permissions.goBack();
        }
        // getting variable from url
        var hash = Page.RouteData.Values["hash"].ToString();

        Forms form = new Forms();
        DataSet first = form.getInfoPublic(hash);
        
        // set info to variable
        var data = first.Tables[0].Rows[0].ItemArray;
        name.Text = data[2].ToString();

        Answer answer = new Answer();
        DataSet answers = answer.getAnswers(hash);

        Repeater1.DataSource = answers;
        Repeater1.DataBind();

        Answer anwer = new Answer();
        DataSet ds = anwer.getInfo(hash);

        var data2 = ds.Tables[0].Rows[0].ItemArray;
        name.Text = data2[2].ToString();

    }

    protected void Create(object sender, EventArgs e)
    {
        Answer answer = new Answer();
        int x = Int32.Parse(rating.Text);
        answer.add(answer1.Text, Name2.Text, x, Page.RouteData.Values["hash"].ToString());

        Name2.Text = "";
        answer1.Text = "";
        rating.Text = "";
    }
}