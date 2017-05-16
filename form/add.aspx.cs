using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_add : System.Web.UI.Page
{
    string hash = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Permissions p = new Permissions();
        p.set();

        hash = Page.RouteData.Values["hash"].ToString();

    }

    protected void Create(object sender, EventArgs e)
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
                form.add(question.Text, Description.Text, color1.Text, color2.Text, hash);
                Response.Redirect("/folder/view/" + hash);
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