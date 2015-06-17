using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.zidian
{
    public partial class fenlei : AdminBase
    {
        protected string types = "";

        private DataTable dt = new DataTable();

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
            dt = LibFenlei.GetFenlei_dt("types='" + types + "'");
            gvqy.DataSource = LibFenlei.GetFenlei("types='" + types + "'");
            gvqy.DataBind();

            this.ddl_cate.SetDataSource(dt);
            this.ddl_cate.Items.Insert(0, "-请选择-");
            LibCache.remove(LibCache.tc_fenlei);
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
            DropDownList ddlcate = gvqy.Rows[e.RowIndex].FindControl("ddlcate") as DropDownList;

            BLL.TcFenlei bbk = new BLL.TcFenlei();
            Model.TcFenlei mbk = new Model.TcFenlei();
            mbk = bbk.GetModel(qyid);
            mbk.Name = txtqymc.Text.Trim();
            mbk.Paixu = txtqypx.Text.GetInt();
            mbk.Types = types;
            var pid = ddlcate.SelectedValue.GetInt();
            if (pid != mbk.Pid)
                mbk.Pid = pid;

            //add 131118 防止死循环
            if (pid == mbk.ID)
                mbk.Pid = 0;

            bbk.Update(mbk);
            gvqy.EditIndex = -1;
            BindGridView();
        }

        protected void btnAddQY_Click(object sender, EventArgs e)
        {
            Model.TcFenlei mzd = new Model.TcFenlei();
            BLL.TcFenlei bzd = new BLL.TcFenlei();
            mzd.Name = txtqymc.Text.Trim();
            mzd.Paixu = txtpx.Text.Trim().GetInt();
            mzd.Types = types;
            mzd.Pid = ddl_cate.SelectedValue.GetInt();
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
                BLL.TcFenlei bbk = new BLL.TcFenlei();
                bbk.Delete(id);
                BindGridView();
            }
        }

        protected void gvqy_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList ddlcate = e.Row.FindControl("ddlcate") as DropDownList;
                if (ddlcate != null)
                {
                    ddlcate.SetDataSource(dt);
                    ddlcate.Items.Insert(0, "-请选择-");
                    ddlcate.SelectedValue = (e.Row.FindControl("hidpid") as HiddenField).Value;
                }
            }
        }
    }
}