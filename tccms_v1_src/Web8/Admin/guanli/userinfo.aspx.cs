using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.guanli
{
    public partial class userinfo : AdminBase
    {
        public int id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"].GetInt();
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            if (id > 0)
            {
                var f = BLL.TcAdmin.Instance.GetModel(id);
                txt_title.Text = f.Name;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            // 1. 这里放置保存窗体中数据的逻辑
            var bllxs = BLL.TcAdmin.Instance;
            var mxs = id > 0 ? bllxs.GetModel(id) : new Model.TcAdmin();
            if (mxs == null)
                mxs = new Model.TcAdmin();
            mxs.Name = txt_title.Text.Trim().GetString();

            string pwd = txt_pwd.Text.Trim();
            string pwd2 = txt_pwd2.Text.Trim();
            if (pwd == pwd2)
            {
                mxs.Pwd = DEncrypt.Encrypt(pwd);

                var dt = bllxs.GetList("name='" + mxs.Name + "'").Tables[0];
                if (id > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        var i = dt.Rows[0]["id"].GetString().GetInt();
                        if (i != id)
                        {
                            Alert("登录名已经存在！");
                        }
                        else
                        {
                            bllxs.Update(mxs);//更新
                            Alert("保存成功！");
                        }
                    }
                    else
                    {
                        bllxs.Update(mxs);//更新
                        Alert("保存成功！");
                    }
                }
                else
                {
                    mxs.Role = 2;
                    if (dt.Rows.Count > 0)
                    {
                        Alert("登录名已经存在！");
                    }
                    else
                    {
                        bllxs.Add(mxs);//添加
                        Alert("保存成功！");
                    }
                }
            }
            else
            {
                Alert("两次密码输入不一致！");
            }
        }
    }
}