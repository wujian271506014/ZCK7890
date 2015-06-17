using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tc.UI
{
    public class ProductInfo : UIBase
    {
        protected Model.TcArticle art = new Model.TcArticle();
        protected Model.TcChanpin prt = new Model.TcChanpin();
        protected Model.TcFenlei cate = new Model.TcFenlei();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var id = Request.QueryInt("id");
                if (id > 0)
                {
                    art = BLL.TcArticle.Instance.GetModel(id);
                    if (art != null)
                    {
                        var c = BLL.TcChanpin.Instance.GetModelList("articleid=" + id);
                        if (c.Count > 0)
                        {
                            prt = c[0];
                        }
                        cate = BLL.TcFenlei.Instance.GetModel(art.Fenleiid.GetInt());
                        if (cate == null)
                            cate = new Model.TcFenlei();
                    }
                    else
                    {
                        art = new Model.TcArticle();
                    }
                }
            }
        }
    }
}