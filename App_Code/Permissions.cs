using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using db;

namespace per
{
    public class Permissions
    {
        public void set(int count, string url, string user_id = null)
        {
            var session = System.Web.HttpContext.Current.Session;

            // if needs to be logged and it's not redirect
            if (session["userId"] == null)
            {
                System.Web.HttpContext.Current.Response.Redirect("/login");
            }

            // if the thing looking for doesn't exist
            if (count <= 0)
            {
                goBack(session["url"].ToString());
            }

            if(user_id != null)
            {
                // if user has no permissions
                if (user_id != session["userId"].ToString())
                {
                    goBack(session["url"].ToString());
                }
            }

            // if none of the above happen then save this as last visited page
            System.Web.HttpContext.Current.Session["url"] = url;
        }

        // goes back to previous page
        public void goBack(string url)
        {
            if (url == null)
            {
                System.Web.HttpContext.Current.Response.Redirect("/");
            }
            else
            {
                System.Web.HttpContext.Current.Response.Redirect(url);
            }
        }
        public void access(string type, string value)
        {
            var query = "";

            if (type == "folder")
            {
                query = "SELECT * FROM WHERE AND f.hash = '"+value+"'";
            }
            else if (type == "form")
            {

            }

            Base conn = new Base();
            DataSet first = conn.getData(query);
        }
    }
}