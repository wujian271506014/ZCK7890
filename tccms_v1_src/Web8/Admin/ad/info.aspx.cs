using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.ad
{
    public partial class info : AdminBase
    {
        public int id = 0;
        public string dp = "display:none";
        public string tupianurl = "";
        public string content = "";

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
                var f = BLL.TcAd.Instance.GetModel(id);
                if (f != null)
                {
                    txt_title.Text = f.Title;
                    ddl_fenlei.SelectedValue = f.Types.GetString();
                    content = f.Code;
                }
            }
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            var bll = BLL.TcAd.Instance;
            var m = id > 0 ? bll.GetModel(id) : new Model.TcAd();
            if (m == null)
                m = new Model.TcAd();
            m.Title = txt_title.Text.GetString();
            m.Types = ddl_fenlei.SelectedValue.GetInt();
            if (m.Types == 2)
            {
                m.Code = Request.Form["txt_content"].GetString().FilterSql();
            }
            else
            {
                m.Code = Request.Form["txt_content2"].GetString().FilterSql();
            }
            if (id > 0)
            {
                bll.Update(m);//更新
            }
            else
            {
                bll.Add(m);//添加
            }

            Alert("保存成功！", "list.aspx");
        }
    }
}