using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace per
{
    public class Permissions
    {
        public void set(int count, string url)
        {
            var session = System.Web.HttpContext.Current.Session;
            
            //if needs to be logged and it's not redirect
            if (session["userId"] == null)
            {
                System.Web.HttpContext.Current.Response.Redirect("/login");
            }

            //if the thing looking for doesn't exist
            if (count <= 0)
            {
                if (session["url"] == null)
                {
                    System.Web.HttpContext.Current.Response.Redirect("/");
                }
                else
                {
                    System.Web.HttpContext.Current.Response.Redirect(session["url"].ToString());
                }
            }
            System.Web.HttpContext.Current.Session["url"] = url;
        }
    }
}