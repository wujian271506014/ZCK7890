using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Tc.UI
{
    public class Danye : UIBase
    {
        public Model.TcDanye mdy = new Model.TcDanye();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var s = Request.QueryString["n"].GetString().FilterSql();
                if (s.Length > 0)
                {
                    var list = BLL.TcDanye.Instance.GetModelList("ename='" + s + "'");
                    if (list.Count > 0)
                    {
                        mdy = list[0];
                    }
                }
            }
        }
    }
}