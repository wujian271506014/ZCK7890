using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.huandeng
{
    public partial class list : AdminBase
    {
        public string types = "";
        public string height = "";
        public string width = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            height = Request.QueryString["height"];
            width = Request.QueryString["width"];
            types = Request.QueryString["types"].GetString();
            if (!IsPostBack)
            {
                bind();
            }
        }

        private void bind()
        {
            var where = "types='" + types + "'";

            #region 设置条件

            #endregion 设置条件

            DataTable dt = BLL.TcHuandeng.Instance.GetList(where).Tables[0].OrderBy("paixu");
            this.rp_list.DataSource = dt;
            this.rp_list.DataBind();
        }

        /// <summary>
        /// 单个删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDel_Click(object sender, EventArgs e)
        {
            var lbtn = sender as LinkButton;
            if (lbtn != null)
            {
                var id = lbtn.CommandArgument.GetInt();
                BLL.TcHuandeng.Instance.Delete(id);
                this.bind();//重新绑定
            }
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string strDels = Request.Form["aids"].GetString();
            if (strDels.Length > 0)
            {
                try
                {
                    BLL.TcHuandeng.Instance.DeleteList(strDels);
                    ClientScript.RegisterClientScriptBlock(GetType(), "", "alert('删除成功');", true);
                }
                catch
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "", "alert('删除失败，请稍后尝试');", true);
                }
            }
            this.bind();//重新绑定
        }
    }
}