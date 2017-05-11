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