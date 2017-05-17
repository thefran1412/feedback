using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using db;

public class Answer
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

    //SELECT avg(a.rating) FROM answers as a

    public DataSet averageRating(string hash)
    {
        //var query = "SELECT a.* FROM forms fo, answers a WHERE a.form_id = fo.id AND fo.hash='" + hash + "';";
        var query = "SELECT AVG(CONVERT(DECIMAL(10,2),a.rating)) FROM forms fo, answers a WHERE a.form_id = fo.id AND fo.hash='" + hash + "';";
        Base conn = new Base();
        DataSet ds = conn.getData(query);

        return ds;
    }

    public void add(string answer, string name, int rating, string hash)
    {
        Answer answer2 = new Answer();
        DataSet ds = answer2.getInfo(hash);

        var getFormId = ds.Tables[0].Rows[0].ItemArray[0];

        // insert folders table
        var query = "INSERT INTO answers (form_id, name, rating, answer) VALUES('" + getFormId + "', '" + name + "', '" + rating + "', '" + answer + "');";
        execute(query);
    }

    public void edit(string name, string color1, string color2, string hash)
    {
        exists(hash);
        access(hash, true);
        var query = "UPDATE forms SET name = '" + name + "', color1 = '" + color1 + "', color2 = '" + color2 + "' WHERE hash = '" + hash + "';";
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
        var valid = true;

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