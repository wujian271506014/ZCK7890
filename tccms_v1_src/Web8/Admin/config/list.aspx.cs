using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.config
{
    public partial class list : AdminBase
    {
        protected string types = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            types = Request.QueryString["types"].GetString().FilterSql();
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            gvqy.DataSource = BLL.TcConfig.Instance.GetList("types='" + types + "'").Tables[0];
            gvqy.DataBind();

            LibCache.remove(LibCache.tc_zidian);

            try
            {
                Cache.Remove("wangzhanpeizhilist");
            }
            catch (System.Exception ex)
            {
            }
        }

        //处于编辑状态
        protected void gvqy_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvqy.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        //取消编辑
        protected void gvqy_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvqy.EditIndex = -1;
            BindGridView();
        }

        //执行编辑
        protected void gvqy_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int qyid = gvqy.DataKeys[e.RowIndex][0].GetString().GetInt();
            TextBox txtqymc = gvqy.Rows[e.RowIndex].FindControl("txtqymc") as TextBox;
            TextBox txtqypx = gvqy.Rows[e.RowIndex].FindControl("txtqypx") as TextBox;
            TextBox txtcontent = gvqy.Rows[e.RowIndex].FindControl("txtcontent") as TextBox;

            BLL.TcConfig bbk = new BLL.TcConfig();
            Model.TcConfig mbk = new Model.TcConfig();
            mbk = bbk.GetModel(qyid);
            mbk.Name = txtqymc.Text;
            mbk.Ename = txtqypx.Text;
            mbk.Types = types;
            mbk.Content = txtcontent.Text;
            bbk.Update(mbk);
            gvqy.EditIndex = -1;
            BindGridView();
        }

        protected void btnAddQY_Click(object sender, EventArgs e)
        {
            Model.TcConfig mzd = new Model.TcConfig();
            BLL.TcConfig bzd = new BLL.TcConfig();
            mzd.Name = txtqymc.Text.Trim();
            mzd.Ename = txtpx.Text.Trim();
            mzd.Types = types;
            mzd.Content = txtcontent.Text.Trim().FilterSql();
            bzd.Add(mzd);
            txtqymc.Text = "";
            txtpx.Text = "";
            txtcontent.Text = "";
            BindGridView();
        }

        //删除
        protected void buttondel_Click(object sender, EventArgs e)
        {
            LinkButton lb = sender as LinkButton;
            int id = lb.CommandArgument.Trim().GetInt();

            int[] ids = { 0 };
            if (!ids.Contains(id))
            {
                BLL.TcConfig bbk = new BLL.TcConfig();
                bbk.Delete(id);
                BindGridView();
            }
        }
    }
}