using Maticsoft.DBUtility;//Please add references
using System;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Tc.DAL
{
    /// <summary>
    /// 数据访问类:TcArticle
    /// </summary>
    public partial class TcArticle
    {
        /// <summary>
        ///  获取前多少条数据
        /// </summary>
        /// <param name="Top"></param>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM TcArticle ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperOleDb.Query(strSql.ToString());
        }
    }
}