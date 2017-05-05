using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DataBase
/// </summary>
public class DataBase
{
    public DataBase()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
        SqlConnection conn = new SqlConnection("Data Source=serverfeedback.database.windows.net;"
         + "Initial Catalog=feedback;"
         + "Persist Security Info=True;"
         + "User ID=admin123;Password=piZzarra1617");

        string sql = null;

        conn.Open();

        // create a SqlCommand object for this connection
        SqlCommand command = conn.CreateCommand();
        sql = "Select * from users where users.email=" + '"' + UserEmail.Text + '"';

        // execute the command that returns a SqlDataReader
        SqlDataReader reader = command.ExecuteReader();

        // close the connection
        reader.Close();
        conn.Close();

    }
}