/**
* Copyright (c) 2013-2020 WuJian.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:88199107  email: 88199107@qq.com
*│　版权所有：吴键
*└──────────────────────────────────┘
*/

using Maticsoft.DBUtility;//Please add references

using System;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace Tc.DAL
{
    /// <summary>
    /// 数据访问类:TcLinks
    /// </summary>
    public partial class TcLinks
    {
        public TcLinks()
        { }

        #region BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperOleDb.GetMaxID("ID", "TcLinks");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TcLinks");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tc.Model.TcLinks model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TcLinks(");
            strSql.Append("Types,Name,Url,LogoUrl,Paixu,IsXianshi,Addtime)");
            strSql.Append(" values (");
            strSql.Append("@Types,@Name,@Url,@LogoUrl,@Paixu,@IsXianshi,@Addtime)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Types", OleDbType.VarChar,255),
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Url", OleDbType.VarChar,255),
					new OleDbParameter("@LogoUrl", OleDbType.VarChar,255),
					new OleDbParameter("@Paixu", OleDbType.Integer,4),
					new OleDbParameter("@IsXianshi", OleDbType.Integer,4),
					new OleDbParameter("@Addtime", OleDbType.Date)};
            parameters[0].Value = model.Types;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Url;
            parameters[3].Value = model.LogoUrl;
            parameters[4].Value = model.Paixu;
            parameters[5].Value = model.IsXianshi;
            parameters[6].Value = model.Addtime;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return GetMaxId();
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tc.Model.TcLinks model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TcLinks set ");
            strSql.Append("Types=@Types,");
            strSql.Append("Name=@Name,");
            strSql.Append("Url=@Url,");
            strSql.Append("LogoUrl=@LogoUrl,");
            strSql.Append("Paixu=@Paixu,");
            strSql.Append("IsXianshi=@IsXianshi,");
            strSql.Append("Addtime=@Addtime");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Types", OleDbType.VarChar,255),
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Url", OleDbType.VarChar,255),
					new OleDbParameter("@LogoUrl", OleDbType.VarChar,255),
					new OleDbParameter("@Paixu", OleDbType.Integer,4),
					new OleDbParameter("@IsXianshi", OleDbType.Integer,4),
					new OleDbParameter("@Addtime", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.Types;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Url;
            parameters[3].Value = model.LogoUrl;
            parameters[4].Value = model.Paixu;
            parameters[5].Value = model.IsXianshi;
            parameters[6].Value = model.Addtime;
            parameters[7].Value = model.ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TcLinks ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TcLinks ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tc.Model.TcLinks GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Types,Name,Url,LogoUrl,Paixu,IsXianshi,Addtime from TcLinks ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            Tc.Model.TcLinks model = new Tc.Model.TcLinks();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tc.Model.TcLinks DataRowToModel(DataRow row)
        {
            Tc.Model.TcLinks model = new Tc.Model.TcLinks();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Types"] != null)
                {
                    model.Types = row["Types"].ToString();
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Url"] != null)
                {
                    model.Url = row["Url"].ToString();
                }
                if (row["LogoUrl"] != null)
                {
                    model.LogoUrl = row["LogoUrl"].ToString();
                }
                if (row["Paixu"] != null && row["Paixu"].ToString() != "")
                {
                    model.Paixu = int.Parse(row["Paixu"].ToString());
                }
                if (row["IsXianshi"] != null && row["IsXianshi"].ToString() != "")
                {
                    model.IsXianshi = int.Parse(row["IsXianshi"].ToString());
                }
                if (row["Addtime"] != null && row["Addtime"].ToString() != "")
                {
                    model.Addtime = DateTime.Parse(row["Addtime"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Types,Name,Url,LogoUrl,Paixu,IsXianshi,Addtime ");
            strSql.Append(" FROM TcLinks ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        #endregion BasicMethod

        #region ExtensionMethod

        #endregion ExtensionMethod
    }
}