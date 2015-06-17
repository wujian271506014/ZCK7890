using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin
{
    public partial class menu : AdminBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Server.Execute(Lib.theme + "admin/menu.aspx");
                //Response.End();
            }
        }
    }
}