using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tc.UI
{
    public class Liuyan : UIBase
    {
        public string res = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var ac = Request.QueryString["ac"].GetString();
                if (ac == "ac")
                {
                    res = "2";
                    try
                    {
                        var code = Request.Form["vcode"].GetString();
                        if (code == Session["vcode"].GetString())
                        {
                            Model.TcLiuyan m = new Model.TcLiuyan();
                            m.Xingming = Request.Form["Xingming"].GetString().FilterSql();
                            m.RukuSj = DateTime.Now;
                            m.QQ = Request.Form["QQ"].GetString().FilterSql();
                            m.Neirong = Request.Form["Neirong"].GetString().FilterSql();
                            //m.GongsiMc = Request.Form["GongsiMc"].GetString().FilterSql();
                            m.Email = Request.Form["Email"].GetString().FilterSql();
                            //m.Dizhi = Request.Form["Dizhi"].GetString().FilterSql();
                            m.Dianhua = Request.Form["Dianhua"].GetString().FilterSql();
                            var id = BLL.TcLiuyan.Instance.Add(m);
                            if (id > 0)
                            {
                                res = "1";
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}