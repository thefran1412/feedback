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
    {   
        sqlCommand cmd = 
        dadesNico.Class1 dades = new dadesNico.Class1();
        DataSet ds = dades.downloadData("select * from users");
        SqlDataAdapter da = new SqlDataAdapter()
    }
}