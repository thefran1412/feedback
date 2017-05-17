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

        rating.Text = "";

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
        title.Text = data[2].ToString();
        conttent.Style.Add("background", "linear-gradient(to right, "+data[4].ToString()+" ,"+data[5].ToString()+" );");

        Answer answer = new Answer();
        DataSet answers = answer.getAnswers(hash);

        Repeater1.DataSource = answers;
        Repeater1.DataBind();

        Answer anwer = new Answer();
        DataSet ds = anwer.getInfo(hash);

        var data2 = ds.Tables[0].Rows[0].ItemArray;
        title.Text = data2[2].ToString();

        Answer raiting = new Answer();
        DataSet raitingA = raiting.averageRating(hash);


        var raiting3 = raitingA.Tables[0].Rows[0].ItemArray;
        rating.Text = raiting3[0].ToString();


    }

    protected void Create(object sender, EventArgs e)
    {
        Answer answer = new Answer();
        int number = Int32.Parse(DropDownList1.SelectedValue);
        answer.add(answer1.Text, Name2.Text, number, Page.RouteData.Values["hash"].ToString());
        string urlRedirect = "/form/view/" + Page.RouteData.Values["hash"];
        Response.Redirect(urlRedirect);

        Name2.Text = "";
        answer1.Text = "";
        DropDownList1.SelectedValue = "";
    }
}