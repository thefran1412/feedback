using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Template : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    public void Logon_Click(object sender, EventArgs e)
    {

        


        if ((UserEmail.Text == "a@b.com") &&
                (UserPass.Text == "123"))
        {
            Session["name"] = UserEmail.Text;
            FormsAuthentication.RedirectFromLoginPage
               (UserEmail.Text, Persist.Checked);
            Response.Redirect("config.aspx");
        }
        else
        {
            Msg.Text = "Invalid credentials. Please try again.";
        }
    }
}
