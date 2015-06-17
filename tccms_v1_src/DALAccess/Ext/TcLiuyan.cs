using Maticsoft.DBUtility;//Please add references
using System;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Tc.DAL
{
    /// <summary>
    /// 数据访问类:TcLiuyan
    /// </summary>
    public partial class TcLiuyan
    {
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM TcLiuyan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperOleDb.Query(strSql.ToString());
        }
    }
}