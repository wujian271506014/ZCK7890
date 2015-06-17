using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Tc
{
    public class LibFenlei
    {
        /// <summary>
        /// 获取无限级分类，返回Datatbale
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public static DataTable GetFenlei_dt(string where)
        {
            var list = GetFenlei(where);
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            foreach (var item in list)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = item.ID;
                dr["name"] = item.Name;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        /// <summary>
        /// 获取无限级分类
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<Model.TcFenlei> GetFenlei(string where)
        {
            var bll = BLL.TcFenlei.Instance;
            var list = bll.DataTableToList(bll.GetList(where).Tables[0].OrderBy("pid,paixu"));
            var res = new List<Model.TcFenlei>();

            foreach (var m in list)
            {
                if (res.Count(p => p.ID == m.ID) < 1)
                {
                    cz(0, m, list, res);
                }
            }

            return res;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="len"></param>
        /// <param name="m"></param>
        /// <param name="list"></param>
        /// <param name="res"></param>
        private static void cz(int len, Model.TcFenlei m, List<Model.TcFenlei> list, List<Model.TcFenlei> res)
        {
            var lt = list.Where(p => p.Pid == m.ID);
            var s = "";
            for (var i = 0; i < len; i++)
            {
                s += "　";
            }
            m.Name = s + m.Name;
            res.Add(m);

            foreach (var item in lt)
            {
                cz(len + 1, item, list, res);
            }
        }
    }
}