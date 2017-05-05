using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string query = "select * from users";
        dadesNico.Class1 dades = new dadesNico.Class1();
        DataSet hola = dades.downloadData(query);

        var adios = hola.Tables["dades"];

    }
}