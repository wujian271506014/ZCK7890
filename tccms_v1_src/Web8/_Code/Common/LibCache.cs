using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Tc
{
    public class LibCache
    {
        /// <summary>
        /// 缓存时间（天）
        /// </summary>
        public static int c_day = 10;

        /// <summary>
        /// 清空指定名称的缓存
        /// </summary>
        /// <param name="cache_name"></param>
        public static void remove(string cache_name)
        {
            HttpContext.Current.Cache.Remove(cache_name);
        }

        #region 分类表缓存

        /// <summary>
        /// 分类表缓存名称
        /// </summary>
        public static string tc_fenlei = "tc_fenlei";

        /// <summary>
        /// 获取分类名称
        /// </summary>
        /// <param name="bianhao"></param>
        /// <returns></returns>
        public static string get_fenlei_name(int id)
        {
            return get_fenlei(id).Name.GetString();
        }

        /// <summary>
        /// 获取分类table
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public static DataTable get_fenlei_dt(string where)
        {
            DataTable dt = new DataTable();
            if (HttpContext.Current.Cache[tc_fenlei] == null)
            {
                dt = BLL.TcFenlei.Instance.GetList("").Tables[0];
                HttpContext.Current.Cache.Insert(tc_fenlei, dt, null, DateTime.Now.AddDays(c_day), TimeSpan.Zero);
            }
            else
            {
                dt = HttpContext.Current.Cache[tc_fenlei] as DataTable;
            }
            return dt.Where(where);
        }

        /// <summary>
        /// 获取分类model类
        /// </summary>
        /// <param name="bianhao"></param>
        /// <returns></returns>
        public static Model.TcFenlei get_fenlei(int id)
        {
            var m = new Model.TcFenlei();
            DataTable dt = get_fenlei_dt("id=" + id);
            if (dt.Rows.Count > 0)
            {
                var list = BLL.TcFenlei.Instance.DataTableToList(dt);
                m = list[0];
            }
            return m;
        }

        /// <summary>
        /// 获取某种types的分类
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public static List<Model.TcFenlei> get_fenleis(string types)
        {
            var list = new List<Model.TcFenlei>();
            DataTable dt = get_fenlei_dt("types='" + types + "'");
            if (dt.Rows.Count > 0)
            {
                list = BLL.TcFenlei.Instance.DataTableToList(dt);
            }
            return list;
        }

        /// <summary>
        /// 获取分类
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static List<Model.TcFenlei> get_fenleis(int pid)
        {
            var list = new List<Model.TcFenlei>();
            DataTable dt = get_fenlei_dt("pid=" + pid);
            if (dt.Rows.Count > 0)
            {
                list = BLL.TcFenlei.Instance.DataTableToList(dt);
            }
            return list;
        }

        /// <summary>
        /// 获取分类
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static List<Model.TcFenlei> get_fenleis(string types, int pid)
        {
            var list = new List<Model.TcFenlei>();
            DataTable dt = get_fenlei_dt("types='" + types + "' and pid=" + pid);
            if (dt.Rows.Count > 0)
            {
                list = BLL.TcFenlei.Instance.DataTableToList(dt);
            }
            return list;
        }

        #endregion 分类表缓存

        #region 字典表缓存

        /// <summary>
        /// 字典表缓存名称
        /// </summary>
        public static string tc_zidian = "tc_zidian";

        /// <summary>
        /// 获取字典名称
        /// </summary>
        /// <param name="bianhao"></param>
        /// <returns></returns>
        public static string get_zidian_name(int id)
        {
            return get_zidian(id).Name.GetString();
        }

        /// <summary>
        /// 获取字典model类
        /// </summary>
        /// <param name="bianhao"></param>
        /// <returns></returns>
        public static Model.TcZidian get_zidian(int id)
        {
            var m = new Model.TcZidian();
            var list = new List<Model.TcZidian>();

            if (HttpContext.Current.Cache[tc_zidian] == null)
            {
                list = BLL.TcZidian.Instance.GetModelList("");
                HttpContext.Current.Cache.Insert(tc_zidian, list, null, DateTime.Now.AddDays(c_day), TimeSpan.Zero);
            }
            else
            {
                list = (List<Model.TcZidian>)HttpContext.Current.Cache[tc_zidian];
            }
            if (list.Count(p => p.ID == id) > 0)
            {
                return list.First(p => p.ID == id);
            }
            else
            {
                return m;
            }
        }

        #endregion 字典表缓存

        #region 皮肤风格专有配置

        public static string get_theme_config(string key)
        {
            var s = "";
            var tme = Lib.theme;
            var thkey = "themeconfig" + tme;
            XElement root;

#if DEBUG
            root = XElement.Parse(File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath(tme + "config.xml")));
#else
            if (HttpContext.Current.Cache[thkey] == null)
            {
                root = XElement.Parse(File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath(tme + "config.xml")));
                HttpContext.Current.Cache.Insert(thkey, root, null, DateTime.Now.AddDays(5), TimeSpan.Zero);
            }
            else
            {
                root = (XElement)HttpContext.Current.Cache[thkey];
            }
#endif

            foreach (var item in root.Elements("key"))
            {
                if (item.Attribute("name").Value == key)
                {
                    s = item.Value;
                    break;
                }
            }
            return s;
        }

        #endregion 皮肤风格专有配置
    }
}