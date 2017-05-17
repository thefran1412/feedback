using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class form_edit : System.Web.UI.Page
{
    string hash = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.RouteData.Values["hash"] == null)
        {
            Permissions.goBack();
        }
        hash = Page.RouteData.Values["hash"].ToString();
        delete.HRef = "/form/delete/" + hash;

        Permissions p = new Permissions();
        p.set();

        Forms form = new Forms();
        DataSet ds = form.getInfo(hash);

        var data = ds.Tables[0].Rows[0];

        // Get folder's hash
        Folders folder = new Folders();
        var folder_hash = folder.getHash(data.ItemArray[1].ToString());
        back.HRef = "/folder/view/" + folder_hash;

        if (!Page.IsPostBack)
        {
            question.Text = data.ItemArray[2].ToString();
            Description.Text = data.ItemArray[7].ToString();
            color1.Text = data.ItemArray[4].ToString();
            color2.Text = data.ItemArray[5].ToString();
        }
    }
    protected void Edit(object sender, EventArgs e)
    {
        color1Label.Text = "";
        color2Label.Text = "";
        String pattern = "^[#](\\d|[AaBbcCdDeEfF]){6}";

        if (MatchString(pattern, color1.Text))
        {
            if (color2.Text != "" ||
            MatchString(pattern, color2.Text))
            {
                Forms form = new Forms();
                form.edit(question.Text, Description.Text, color1.Text, color2.Text, hash);
                Response.Redirect("/form/view/" + hash);
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

    public Boolean MatchString(String pattern, String text)
    {
        Regex rgx = new Regex(pattern);
        return rgx.IsMatch(text);
    }
}