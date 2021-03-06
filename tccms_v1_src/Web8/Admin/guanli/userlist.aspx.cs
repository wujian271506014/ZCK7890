﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.guanli
{
    public partial class userlist : AdminBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        private void bind()
        {
            var where = "";

            #region 设置条件

            #endregion 设置条件

            DataTable dt = BLL.TcAdmin.Instance.GetList(where).Tables[0];
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
                var m = BLL.TcAdmin.Instance.GetModel(id);
                if (m != null)
                {
                    if (m.Role != 1)
                    {
                        BLL.TcAdmin.Instance.Delete(id);
                    }
                }
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
                    BLL.TcAdmin.Instance.DeleteList(strDels);
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