using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using db;

public class Folders
{
    public DataSet getInfo(string hash)
    {
        exists(hash);
        access(hash, true);

        var query = "SELECT * FROM folders WHERE hash='"+hash+"';";
        Base conn = new Base();
        DataSet ds = conn.getData(query);

        return ds;
    }

    public void add(string name, string color1, string color2)
    {
        var hashed = hash(name);
        var user_id = System.Web.HttpContext.Current.Session["userId"];
        var query = "";
        var last_id = 0;

        // insert folders table
        query = "INSERT INTO folders (name, color1, color2, hash) VALUES('" + name + "', '" + color1 + "', '" + color2 + "', '" + hashed + "');";
        execute(query);

        // get folder's id
        last_id = lastInsertedId("folders");

        // insert users_folders table
        query = "INSERT INTO users_folders (user_id, folder_id, is_admin) VALUES(" + user_id + ", " + last_id + ", " + 1 + ");";
        execute(query);
    }

    public void edit(string name, string color1, string color2, string hash)
    {
        exists(hash);
        access(hash, true);
        var query = "UPDATE folders SET name = '" + name + "', color1 = '" + color1 + "', color2 = '" + color2 + "' WHERE hash = '" + hash + "';";
        execute(query);
    }

    public void delete(string hash)
    {
        exists(hash);
        access(hash, false);
        var query = "DELETE FROM folders WHERE hash = '" + hash + "';";
        execute(query);
    }

    public void exists(string hash)
    {
        var query = "SELECT * FROM folders WHERE hash = '" + hash + "'";
        Base conn = new Base();
        DataSet first = conn.getData(query);

        if(first.Tables[0].Rows.Count != 1)
        {
            System.Web.HttpContext.Current.Response.Redirect("/folder/index");
        }
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
        var q = "SELECT * FROM " + table + " ORDER BY id DESC";
        Base conn = new Base();
        DataSet ds = conn.getData(q);

        var id = ds.Tables[0].Rows[0].ItemArray[0];

        return Convert.ToInt32(id);
    }

    public void access(string hash, bool saveUrl)
    {
        var query = "SELECT uf.* FROM users_folders uf, folders f WHERE uf.folder_id = f.id AND f.hash = '" + hash + "'";
        var valid = false;

        Base conn = new Base();
        DataSet first = conn.getData(query);

        for (int i = 0; i < first.Tables[0].Rows.Count; i++)
        {
            var data = first.Tables[0].Rows[i].ItemArray;
            var val = data[1].ToString();

            var user_id = System.Web.HttpContext.Current.Session["userId"].ToString();

            if (user_id == val)
            {
                valid = true;
            }

        }
        if (valid == false)
        {
            Permissions.goBack();
        }
        else
        {
            if(saveUrl == true)
            {
                Permissions.currentUrl();
            }
        }
    }
}