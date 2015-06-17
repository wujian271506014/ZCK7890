using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tc
{
    public class PageBase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        public void SetPage(string name)
        {
            var url = Request.Url;
            var u = Lib.theme + name + url.Query.GetString();
            Server.Execute(u);
            Response.End();
        }

        //public void SetPage(string name, string param)
        //{
        //    if (name.Contains("?"))
        //        name += "&";
        //    else
        //        name += "?";
        //    name += param;
        //    var url = Request.Url;
        //    //Server.Execute(Lib.theme + name);
        //    //Response.End();
        //}
    }
}