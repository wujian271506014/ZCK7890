using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
#if DEBUG
                txt_name.Text = "admin";
                txt_pwd.Text = "tuichu";
                Button1_Click(sender, e);
#endif
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text.Replace("'", "").FilterSql();
            string pwd = DEncrypt.Encrypt(this.txt_pwd.Text.FilterSql());
            if (name.Length > 0 && pwd.Length > 0)
            {
                Tc.BLL.TcAdmin ao = new Tc.BLL.TcAdmin();
                List<Tc.Model.TcAdmin> t = ao.GetModelList("name='" + name + "'");
                if (t.Count <= 0)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "login", "alert('用户名或密码错误！请重新尝试！')", true);
                }
                else
                {
                    if (t[0].Pwd.GetString().ToLower() == pwd.ToLower())
                    {
                        Session[LibAdmin.Session_admin] = t[0];

                        Random r = new Random();
                        string s = DateTime.Now.ToLongTimeString() + r.Next(1000000);
                        FormsAuthentication.SetAuthCookie("admin" + s, false);
                        Response.Redirect("main.aspx");
                    }

                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "login", "alert('用户名或密码错误！请重新尝试')", true);
                    }
                }
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "login", "alert('请输入用户名和密码')", true);
            }
        }
    }
}