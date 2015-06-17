using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.zidian
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
            gvqy.DataSource = BLL.TcZidian.Instance.GetList("types='" + types + "'").Tables[0].OrderBy("paixu");
            gvqy.DataBind();

            LibCache.remove(LibCache.tc_zidian);
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

            BLL.TcZidian bbk = new BLL.TcZidian();
            Model.TcZidian mbk = new Model.TcZidian();
            mbk = bbk.GetModel(qyid);
            mbk.Name = txtqymc.Text;
            mbk.Paixu = txtqypx.Text.GetInt();
            mbk.Types = types;
            bbk.Update(mbk);
            gvqy.EditIndex = -1;
            BindGridView();
        }

        protected void btnAddQY_Click(object sender, EventArgs e)
        {
            Model.TcZidian mzd = new Model.TcZidian();
            BLL.TcZidian bzd = new BLL.TcZidian();
            mzd.Name = txtqymc.Text.Trim();
            mzd.Paixu = txtpx.Text.Trim().GetInt();
            mzd.Types = types;
            mzd.Pid = 0;
            bzd.Add(mzd);
            txtqymc.Text = "";
            txtpx.Text = "";
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
                BLL.TcZidian bbk = new BLL.TcZidian();
                bbk.Delete(id);
                BindGridView();
            }
        }
    }
}