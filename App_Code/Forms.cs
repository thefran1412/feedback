using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using db;

public class Forms
{
    public DataSet getInfo(string hash)
    {
        exists(hash);
        access(hash, true);

        var query = "SELECT * FROM forms WHERE hash='" + hash + "';";
        Base conn = new Base();
        DataSet ds = conn.getData(query);

        return ds;
    }

    public DataSet getAnswers(string hash)
    {
        exists(hash);
        access(hash, true);

        var query = "SELECT a.* FROM forms fo, answers a WHERE a.form_id = fo.id AND fo.hash='" + hash + "';";
        Base conn = new Base();
        DataSet ds = conn.getData(query);

        return ds;
    }

    public void add(string name, string description,  string color1, string color2, string folder_hash)
    {
        var hashed = hash(name);
        Folders f = new Folders();
        DataSet ds = f.getInfo(folder_hash);

        var folder_id = ds.Tables[0].Rows[0].ItemArray[0];

        // insert folders table
        var query = "INSERT INTO forms (name, description, color1, color2, hash, visible, folder_id) VALUES('" + name + "', '" + description + "', '" + color1 + "', '" + color2 + "', '" + hashed + "', 1, " + folder_id + ");";
        execute(query);
    }

    public void edit(string name, string color1, string color2, string hash)
    {
        exists(hash);
        access(hash, true);
        var query = "UPDATE forms SET name = '" + name + "', color1 = '" + color1 + "', color2 = '" + color2 + "' WHERE hash = '" + hash + "';";
        //var query = "UPDATE forms SET description = '" + description + "' name = '" + name + "', color1 = '" + color1 + "', color2 = '" + color2 + "' WHERE hash = '" + hash + "';";
        execute(query);
    }

    public void delete(string hash)
    {
        exists(hash);
        access(hash, false);

        // delete folder
        var query = "DELETE FROM forms WHERE hash = '" + hash + "';";
        execute(query);
    }

    public void exists(string hash)
    {
        var query = "SELECT * FROM forms WHERE hash = '" + hash + "'";
        Base conn = new Base();
        DataSet first = conn.getData(query);

        if (first.Tables[0].Rows.Count != 1)
        {
            Permissions.goBack();
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
        var query = "SELECT uf.* FROM forms fo, folders f, users_folders uf WHERE fo.folder_id = f.id AND f.id = uf.folder_id AND fo.hash = '" + hash + "'";
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
            if (saveUrl == true)
            {
                Permissions.currentUrl();
            }
        }
    }
}