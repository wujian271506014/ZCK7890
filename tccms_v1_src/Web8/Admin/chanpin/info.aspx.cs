using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.chanpin
{
    public partial class info : AdminBase
    {
        public string types = "";
        public int id = 0;
        public string dp = "display:none";
        public string tupianurl = "";
        public string content = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"].GetInt();
            types = Request.QueryString["types"].GetString();
            if (!IsPostBack)
            {
                ddl_fenlei.SetDataSource(LibFenlei.GetFenlei_dt("types='" + types + "'"));
                LoadData();
            }
        }

        private void LoadData()
        {
            if (id > 0)
            {
                var f = BLL.TcArticle.Instance.GetModel(id);
                if (f != null)
                {
                    txt_title.Text = f.Title;
                    txt_jianyao.Text = f.Jianyao;
                    ddl_fenlei.SelectedValue = f.Fenleiid.GetString();
                    content = f.Content;
                    if (f.Tupian.GetString().Length > 0)
                    {
                        dp = "";
                        tupianurl = LibFile.get_img(f.Tupian.GetString(), "", "");
                        hd_tupian.Value = f.Tupian.GetString();
                    }
                    var c = BLL.TcChanpin.Instance.GetModelList("articleid=" + f.ID);
                    if (c.Count > 0)
                    {
                        txt_jianyao.Text = c[0].Shuxing;
                    }
                }
            }
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            var bll = BLL.TcArticle.Instance;
            var m = id > 0 ? bll.GetModel(id) : new Model.TcArticle();
            if (m == null)
                m = new Model.TcArticle();
            m.Title = txt_title.Text.GetString();

            //m.Jianyao = txt_jianyao.Text.GetString();
            m.Fenleiid = ddl_fenlei.SelectedValue.GetInt();
            m.Content = Request.Form["txt_content"].GetString().FilterSql();
            m.Jianyao = m.Content.DeleteHMTL().Subs(180);
            m.Tupian = this.hd_tupian.Value.GetString();
            m.Types = types;
            if (id > 0)
            {
                bll.Update(m);//更新
                var c = BLL.TcChanpin.Instance.GetModelList("articleid=" + id);
                if (c.Count > 0)
                {
                    c[0].Shuxing = txt_jianyao.Text.FilterSql();
                    BLL.TcChanpin.Instance.Update(c[0]);
                }
                else
                {
                    BLL.TcChanpin.Instance.Add(new Model.TcChanpin() { Addtime = DateTime.Now, Articleid = id, Shuxing = txt_jianyao.Text.FilterSql() });
                }
            }
            else
            {
                m.Addtime = DateTime.Now;
                id = bll.Add(m);//添加
                BLL.TcChanpin.Instance.Add(new Model.TcChanpin() { Addtime = DateTime.Now, Articleid = id, Shuxing = txt_jianyao.Text.FilterSql() });
            }

            Alert("保存成功！", "list.aspx?types=" + types);
        }
    }
}