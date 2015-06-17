using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Tc.UI
{
    public class ProductList : UIBase
    {
        protected DataTable dt = new DataTable();
        public string types = "c";
        public Model.TcFenlei cate = new Model.TcFenlei() { Name = "" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void aspnetpage_PageChanged(object sender, EventArgs e)
        {
            var aspnetpage = sender as Wuqi.Webdiyer.AspNetPager;
            int cid = Request.QueryString["c"].GetInt();

            var where = "types='" + types + "'";

            #region 设置条件

            if (cid > 0)
            {
                where += " and Fenleiid=" + cid;
                cate = BLL.TcFenlei.Instance.GetModel(cid);
                if (cate == null)
                {
                    cate = new Model.TcFenlei() { Name = "" };
                }
            }

            #endregion 设置条件

            int currentPage = Request.QueryString["page"].GetInt();
            if (currentPage <= 0)
            {
                currentPage = 1;
            }
            int start = (currentPage - 1) * aspnetpage.PageSize + 1;

            var sumcount = 0;
            dt = BLL.BLLP.Instance.Get_Page_List("TcArticle", "id desc", start, aspnetpage.PageSize, where, out sumcount);
            List<string> list = new List<string>();
            dt.Columns.Add("shuxing");
            foreach (DataRow item in dt.Rows)
            {
                list.Add(item["id"].GetString());
            }
            if (list.Count > 0)
            {
                string w = string.Join(",", list.ToArray());
                DataTable dtcp = BLL.TcChanpin.Instance.GetList("Articleid in(" + w + ")").Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    DataTable dttmp = dtcp.Where("Articleid=" + item["id"].GetString());
                    if (dttmp.Rows.Count > 0)
                    {
                        item["shuxing"] = dttmp.Rows[0]["shuxing"].GetString();
                    }
                    else
                    {
                        item["shuxing"] = "";
                    }
                }
            }
            aspnetpage.RecordCount = sumcount;
        }
    }
}