using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace db
{
    public class Base
    {
        SqlConnection conn = new SqlConnection("Data Source=serverfeedback.database.windows.net;"
            + "Initial Catalog=feedback;"
            + "Persist Security Info=True;"
            + "User ID=admin123;Password=piZzarra1617");

        public DataSet getData(string query)
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
}