﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;
using db;

public partial class login_Default : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection con = new SqlConnection();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();


    protected void Page_Load(Object sender, EventArgs e)
    {
        if (Session["userId"] != "" && Session["userId"] != null)
        {
            Response.Redirect("/folder/index");
        }

        con.ConnectionString = "Data Source=serverfeedback.database.windows.net; Initial Catalog=feedback; Persist Security Info=True; User ID=admin123; Password=piZzarra1617;";
        con.Open();
    }

    public void Logon_Click(object sender, EventArgs e)
    {
        var userPass = HashStrings.GetHashedString(UserPass.Text);
        cmd.CommandText = "SELECT * FROM users WHERE email = '" + UserEmail.Text + "'AND password='" + userPass + "'";
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(ds, "reg");

        if (ds.Tables[0].Rows.Count > 0)
        {
            Msg.Text = "Data ok";
            object hol = ds.Tables[0].Rows[0].ItemArray;
            string userId = ds.Tables[0].Rows[0].ItemArray[0].ToString();

            Session["userId"] = userId;

            Response.Redirect("/folder/index");

        }
        else
        {
            Msg.Text = "Incorrect email or password.";
        }
    }
}