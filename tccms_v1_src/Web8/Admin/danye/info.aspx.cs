using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.danye
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
                ddl_fenlei.SetDataSource(BLL.TcZidian.Instance.GetList("types='danye'").Tables[0].OrderBy("paixu"));
                LoadData();
            }
        }

        private void LoadData()
        {
            if (id > 0)
            {
                var f = BLL.TcDanye.Instance.GetModel(id);
                if (f != null)
                {
                    txt_title.Text = f.Name;
                    txt_ename.Text = f.Ename;
                    ddl_fenlei.SelectedValue = f.Fenlei.GetString();
                    content = f.Content;
                    if (f.Tupian.GetString().Length > 0)
                    {
                        dp = "";
                        tupianurl = LibFile.get_img(f.Tupian.GetString(), "", "");
                        hd_tupian.Value = f.Tupian.GetString();
                    }
                }
            }
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            var bll = BLL.TcDanye.Instance;
            var m = id > 0 ? bll.GetModel(id) : new Model.TcDanye();
            if (m == null)
                m = new Model.TcDanye();
            m.Name = txt_title.Text.GetString();
            m.Ename = txt_ename.Text.GetString();
            m.Fenlei = ddl_fenlei.SelectedValue.GetInt();
            m.Content = Request.Form["txt_content"].GetString().FilterSql();
            m.Tupian = this.hd_tupian.Value.GetString();
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