using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tc.UI
{
    public class Links : UIBase
    {
        protected List<Model.TcLinks> list_link = new List<Model.TcLinks>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                list_link = BLL.TcLinks.Instance.GetModelList("IsXianshi=1").OrderBy(p => p.Paixu).ToList();
            }
        }
    }
}