using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using db;

    public class Permissions
    {
        public void set()
        {
            var session = System.Web.HttpContext.Current.Session;

            // if needs to be logged and it's not redirect
            if (session["userId"] == null)
            {
                System.Web.HttpContext.Current.Response.Redirect("/login");
            }
        }

        // if user doesn't own the folder then kicks him out
        public void accessFolder(string value)
        {
            var query = "SELECT uf.* FROM users_folders uf, folders f WHERE uf.folder_id = f.id AND f.hash = '"+value+"'";
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
                    //var admin = data[3].ToString();
                    //if (admin == "True")
                    //{
                    //    return "admin";
                    //}
                    //return "user";
                    valid = true;   
                }
            }
            if(valid == false)
            {
                goBack();
            }
            else
            {
                currentUrl();
            }

            //return "none";

        }
        // if user doesn't own the form then kicks him out
        public void accessForm(string value)
        {
            var query = "SELECT uf.* FROM users_folders uf, folders f, forms fo WHERE uf.folder_id = f.id AND fo.folder_id = f.id AND fo.hash = '" + value + "'";
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
                    //var admin = data[3].ToString();
                    //if (admin == "True")
                    //{
                    //    return "admin";
                    //}
                    //return "user";
                    valid = true;

                }

            }
            var uu = System.Web.HttpContext.Current.Session["url"].ToString();
            if (valid == false)
            {
                goBack();
            }
            else
            {
                currentUrl();
            }

            //return "none";
        }

        // goes back to previous page
        public static void goBack()
        {
            if (System.Web.HttpContext.Current.Session["url"] == null)
            {
                System.Web.HttpContext.Current.Response.Redirect("/");
            }
            else
            {
                System.Web.HttpContext.Current.Response.Redirect(System.Web.HttpContext.Current.Session["url"].ToString());
            }
        }

        // sets current url
        public static void currentUrl()
        {
            System.Web.HttpContext.Current.Session["url"] = System.Web.HttpContext.Current.Request.Url.ToString();
        }
    }