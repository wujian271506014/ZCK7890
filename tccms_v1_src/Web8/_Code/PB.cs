using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tc
{
    public class PB
    {
        #region 获取网站配置

        public static string Get(string key)
        {
            var s = "";
            var list = new List<Model.TcConfig>();
            if (HttpContext.Current.Cache["wangzhanpeizhilist"] == null)
            {
                list = BLL.TcConfig.Instance.GetModelList("");
                HttpContext.Current.Cache.Insert("wangzhanpeizhilist", list, null, DateTime.Now.AddHours(1), TimeSpan.Zero);
            }
            else
            {
                list = (List<Model.TcConfig>)HttpContext.Current.Cache["wangzhanpeizhilist"];
            }
            var mlist = list.Where(p => p.Ename == key);//应该就只有一个值的
            foreach (Model.TcConfig item in mlist)
            {
                s = item.Content;
            }
            return s;
        }

        #endregion 获取网站配置

        #region 获取幻灯片图片

        /// <summary>
        /// 获取幻灯片
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public static List<Tc.Model.TcHuandeng> get_huandong(string types)
        {
            return BLL.TcHuandeng.Instance.GetModelList("types = '" + types + "'");
        }

        #endregion 获取幻灯片图片

        #region 获取产品

        /// <summary>
        /// 获取产品
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static List<Tc.Model.TcArticle> get_chanpin(int top, string where, string order)
        {
            if (where.Length > 0)
                where = " and types='c'";
            else
                where = " types='c'";
            var bll = BLL.TcArticle.Instance;
            return bll.DataTableToList(bll.GetList(top, where, order).Tables[0]);
        }

        #endregion 获取产品

        #region 获取文章资讯

        /// <summary>
        /// 获取文章资讯
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static List<Tc.Model.TcArticle> get_article(int top, string where, string order)
        {
            var bll = BLL.TcArticle.Instance;
            return bll.DataTableToList(bll.GetList(top, where, order).Tables[0]);
        }

        #endregion 获取文章资讯

        #region 获取单页内容

        /// <summary>
        /// 获取单页内容，自动删除html代码
        /// </summary>
        /// <param name="ename"></param>
        /// <returns></returns>
        public static string get_danye(string ename)
        {
            return get_danye_withhtml(ename).DeleteHMTL();
        }

        /// <summary>
        /// 获取单页内容
        /// </summary>
        /// <param name="ename"></param>
        /// <returns></returns>
        public static Model.TcDanye get_danye_model(string ename)
        {
            var l = BLL.TcDanye.Instance.GetModelList("ename='" + ename + "'");
            if (l.Count > 0)
            {
                return l[0];
            }
            else
            {
                return new Model.TcDanye() { Content = "", Ename = "", Fenlei = 0, Name = "", Tupian = "" };
            }
        }

        /// <summary>
        /// 获取单页列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<Model.TcDanye> get_danye_list(string where)
        {
            var l = BLL.TcDanye.Instance.GetModelList(where);
            return l;
        }

        /// <summary>
        /// 获取单页内容，保留html代码
        /// </summary>
        /// <param name="ename"></param>
        /// <returns></returns>
        public static string get_danye_withhtml(string ename)
        {
            var l = BLL.TcDanye.Instance.GetModelList("ename='" + ename + "'");
            if (l.Count > 0)
            {
                return l[0].Content;
            }
            else
            {
                return "";
            }
        }

        #endregion 获取单页内容

        #region 获取友情连接

        /// <summary>
        /// 获取友情连接
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static List<Tc.Model.TcLinks> get_links(int top, string where)
        {
            var bll = BLL.TcLinks.Instance;
            var list = bll.DataTableToList(bll.GetList(where).Tables[0]);
            return list.Take(top).ToList();
        }

        #endregion 获取友情连接

        #region 获取广告内容

        /// <summary>
        /// 获取广告内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string get_ad(int id)
        {
            var res = "";
            var m = BLL.TcAd.Instance.GetModel(id);
            if (m != null)
            {
                res = m.Code;
            }
            return res;
        }

        /// <summary>
        /// 根据标题获取广告名称
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string get_ad(string title)
        {
            var res = "";
            var m = BLL.TcAd.Instance.GetModelList("title='" + title.FilterSql() + "'");
            if (m.Count > 0)
            {
                res = m[0].Code;
            }
            return res;
        }

        #endregion 获取广告内容

        #region 获取字典

        /// <summary>
        /// 获取字典
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<Model.TcZidian> get_zidian(string where)
        {
            var list = BLL.TcZidian.Instance.GetModelList(where).OrderBy(p => p.Paixu).ToList();
            return list;
        }

        #endregion 获取字典
    }
}