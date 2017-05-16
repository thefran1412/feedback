using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using db;

namespace crud
{
    public class c
    {
        // to create folder
        public void createFolder(string name, string color1, string color2)
        {
            var hashed = hash(name);
            var user_id = System.Web.HttpContext.Current.Session["userId"];
            var query = "";
            var last_id = 0;

            // insert folders table
            query = "INSERT INTO folders (name, color1, color2, hash) VALUES('"+name+"', '"+color1+ "', '" + color2 + "', '"+hashed+"');";
            execute(query);

            // get folder's id
            last_id = lastInsertedId("folders");

            // insert users_folders table
            query = "INSERT INTO users_folders (user_id, folder_id, is_admin) VALUES(" + user_id + ", " + last_id + ", " + 1 + ");";
            execute(query);
        }

        // to edit folder
        public void editFolder(string name, string color1, string color2, string hash)
        {
            // insert folders table
            var query = "UPDATE folders SET name = '"+name+ "', color1 = '" + color1 + "', color2 = '" + color2 + "' WHERE hash = '"+ hash +"';";
            execute(query);
        }

        public void deleteFolder(string hash)
        {
            // insert folders table
            var query = "DELETE FROM folders WHERE hash = '" + hash + "';";
            execute(query);
        }

        public void execute(string query)
        {
            Base conn = new Base();
            conn.sendData(query);
        }

        public string hash(string value)
        {
            value = value + DateTime.Now.ToString("yyyyMMddHHmmssfff");

            return HashStrings.GetHashedString(value);
        }

        // returns last inserted id of the table you specify
        public int lastInsertedId(string table)
        {
            var q = "SELECT * FROM "+table+" ORDER BY id DESC";
            Base conn = new Base();
            DataSet ds = conn.getData(q);

            var id = ds.Tables[0].Rows[0].ItemArray[0];

            return Convert.ToInt32(id);
        }
    }
}