using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.guanli
{
    public partial class pwd : AdminBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_title.Text = My.Name;
            }
        }

        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            string pwd = txt_oldpwd.Text.Trim();
            string newpwd = txt_newpwd.Text.Trim();
            string newpwd2 = txt_newpwd2.Text.Trim();
            if (newpwd == newpwd2)
            {
                BLL.TcAdmin ado = new BLL.TcAdmin();

                if (DEncrypt.Encrypt(pwd).ToLower() == My.Pwd.ToLower())
                {
                    if (txt_title.Text.Trim().Length > 0)
                    {
                        My.Name = txt_title.Text;
                    }
                    My.Pwd = DEncrypt.Encrypt(newpwd);
                    ado.Update(My);
                    Session[LibAdmin.Session_admin] = My;
                    Alert("保存成功!");
                }
                else
                {
                    Alert("原密码错误!");
                }
            }
            else
            {
                Alert("两次密码不一致!");
            }
        }
    }
}