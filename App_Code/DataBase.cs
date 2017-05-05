using System;
using System.Data;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class DataBase
{
    SqlConnection conn = new SqlConnection("Data Source=serverfeedback.database.windows.net;"
        + "Initial Catalog=feedback;"
        + "Persist Security Info=True;"
        + "User ID=admin123;Password=piZzarra1617");

    public Object getData(string query)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);

        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        conn.Close();

        return ds;
    }
}
