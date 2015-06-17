using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.links
{
    public partial class info : AdminBase
    {
        public int id = 0;
        public string dp = "display:none";
        public string tupianurl = "";
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
                var f = BLL.TcLinks.Instance.GetModel(id);
                txt_name.Text = f.Name;
                txt_url.Text = f.Url.GetString();
                rb_xianshi.SelectedValue = f.IsXianshi.GetString();
                txt_paixu.Text = f.Paixu.GetString();
                if (f.LogoUrl.GetString().Length > 0)
                {
                    dp = "";
                    tupianurl = LibFile.get_img(f.LogoUrl.GetString(), "88", "31");
                    hd_tupian.Value = f.LogoUrl.GetString();
                }
            }
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            var bll = BLL.TcLinks.Instance;
            var m = id > 0 ? bll.GetModel(id) : new Model.TcLinks();
            if (m == null)
            {
                m = new Model.TcLinks();
            }
            m.Name = txt_name.Text.GetString();
            m.Url = txt_url.Text.GetString();
            m.IsXianshi = rb_xianshi.SelectedValue.GetInt();
            m.Paixu = txt_paixu.Text.GetInt();
            m.LogoUrl = this.hd_tupian.Value.GetString();
            if (id > 0)
            {
                bll.Update(m);//更新
            }
            else
            {
                m.Addtime = DateTime.Now;
                bll.Add(m);//添加
            }

            Alert("保存成功！", "list.aspx");
        }
    }
}