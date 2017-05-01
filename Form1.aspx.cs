using System;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = "select * from test";
        dadesNico.Class1 dades = new dadesNico.Class1();
        DataSet dts = dades.downloadData(query);

        GridView1.DataSource = dts.Tables["dades"];
        GridView1.DataBind();
        
    }
}