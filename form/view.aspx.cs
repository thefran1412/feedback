using System;
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

        // if there's an entry stay in page and continue, else go to page before this
        Permissions p = new Permissions();
        p.set();

        Forms form = new Forms();
        DataSet first = form.getInfo(hash);
        
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
    }
}