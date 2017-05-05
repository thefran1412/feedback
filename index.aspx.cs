using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
<<<<<<< HEAD
    {

        string query = "select * from users";
        dadesNico.Class1 dades = new dadesNico.Class1();
        DataSet hola = dades.downloadData(query);

        var adios = hola.Tables["dades"];

=======
    {   
        sqlCommand cmd = 
        dadesNico.Class1 dades = new dadesNico.Class1();
        DataSet ds = dades.downloadData("select * from users");
        SqlDataAdapter da = new SqlDataAdapter()
>>>>>>> 799e7ed5b0041e9ed30d1f70ec33d7950c36329b
    }
}