using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Tc.DAL
{
    public class DALP
    {
        public DataTable Get_Page_List(string tablename, string orderby, int startrecordindex, int pagesize, string where, out int sumcount)
        {
            sumcount = 0;
            StringBuilder sb = new StringBuilder();
            DataTable dt;
            var orders = "";
            var sql = "select * from " + tablename;
            if (where.Length > 0)
            {
                sql += " where " + where;
            }
            if (orderby.Length > 0)
            {
                orders = orderby;
            }
            else
            {
                orders = " id desc ";
            }
            var sql2 = @"select top " + pagesize + @"
                                    *
                            from    (" + sql + @") t ";

            if (startrecordindex - 1 > 0)
            {
                startrecordindex = startrecordindex - 1;
                sql2 += @" where  id not in(
                                        select top " + startrecordindex + @"
                                                    id
                                            from     (" + sql + @") t
                                            order by " + orders + @"
                                )";
            }

            sql2 += " order by " + orders;
            dt = DbHelperOleDb.Query(sql2).Tables[0];

            //计算条数
            sql = "select count(1) from " + tablename;
            if (where.Length > 0)
            {
                sql += " where " + where;
            }
            DataTable dmp = DbHelperOleDb.Query(sql).Tables[0];
            if (dmp.Rows.Count > 0)
            {
                sumcount = dmp.Rows[0][0].GetString().GetInt();
            }
            return dt;
        }
    }
}