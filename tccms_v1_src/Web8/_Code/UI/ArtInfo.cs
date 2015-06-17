using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tc.UI
{
    public class ArtInfo : UIBase
    {
        protected Model.TcArticle art = new Model.TcArticle();
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