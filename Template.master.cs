using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;

public partial class Template : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    public void Logon_Click(object sender, EventArgs e)
    {

        //string constr = ConfigurationManager.ConnectionStrings["asd"].ConnectionString;
        //SqlConnection con = new SqlConnection(constr);
        //string query = "SELECT * FROM users WHERE users.email=" + '"' + UserEmail.Text + '"';


        //SqlCommand cmd = new SqlCommand(query, con);

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
