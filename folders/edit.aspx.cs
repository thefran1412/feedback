using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using crud;
using System.Text.RegularExpressions;

public partial class folders_edit : System.Web.UI.Page
{
    string hash = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.RouteData.Values["hash"] == null)
        {
            Permissions.goBack();
        }

        hash = Page.RouteData.Values["hash"].ToString();

        Permissions p = new Permissions();
        p.set();

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
        {
            color1Label.Text = "";
            color2Label.Text = "";
            String pattern = "^[#](\\d|[AaBbcCdDeEfF]){6}";

            if (MatchString(pattern, color1.Text))
            {
                if (color2.Text != "" ||
                MatchString(pattern, color2.Text))
                {
                    Folders folder = new Folders();
                    folder.edit(name.Text, color1.Text, color2.Text, hash);
                    Response.Redirect("/folder/index/");
                }
                else
                {
                    color2Label.Text = "The Hexadecimal code introduced is not valid";
                }
            }
            else
            {
                color1Label.Text = "The Hexadecimal code introduced is not valid";
            }
        }
    }

    public Boolean MatchString(String pattern, String text)
    {
        Regex rgx = new Regex(pattern);
        return rgx.IsMatch(text);
    }
}