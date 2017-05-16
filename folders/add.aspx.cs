using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crud;
using System.Text.RegularExpressions;

public partial class folders_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Permissions p = new Permissions();
        p.set();

    }

    protected void Create(object sender, EventArgs e)
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
                    folder.add(name.Text, color1.Text, color2.Text);
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