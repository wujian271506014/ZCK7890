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
    /// 数据访问类:TcConfig
    /// </summary>
    public partial class TcConfig
    {
        public TcConfig()
        { }

        #region BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperOleDb.GetMaxID("ID", "TcConfig");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TcConfig");
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
        public int Add(Tc.Model.TcConfig model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TcConfig(");
            strSql.Append("Ename,Name,Types,Content)");
            strSql.Append(" values (");
            strSql.Append("@Ename,@Name,@Types,@Content)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Ename", OleDbType.VarChar,255),
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Types", OleDbType.VarChar,255),
					new OleDbParameter("@Content", OleDbType.VarChar,0)};
            parameters[0].Value = model.Ename;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Types;
            parameters[3].Value = model.Content;

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
        public bool Update(Tc.Model.TcConfig model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TcConfig set ");
            strSql.Append("Ename=@Ename,");
            strSql.Append("Name=@Name,");
            strSql.Append("Types=@Types,");
            strSql.Append("Content=@Content");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Ename", OleDbType.VarChar,255),
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Types", OleDbType.VarChar,255),
					new OleDbParameter("@Content", OleDbType.VarChar,0),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.Ename;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Types;
            parameters[3].Value = model.Content;
            parameters[4].Value = model.ID;

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
            strSql.Append("delete from TcConfig ");
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
            strSql.Append("delete from TcConfig ");
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
        public Tc.Model.TcConfig GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Ename,Name,Types,Content from TcConfig ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            Tc.Model.TcConfig model = new Tc.Model.TcConfig();
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
        public Tc.Model.TcConfig DataRowToModel(DataRow row)
        {
            Tc.Model.TcConfig model = new Tc.Model.TcConfig();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Ename"] != null)
                {
                    model.Ename = row["Ename"].ToString();
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Types"] != null)
                {
                    model.Types = row["Types"].ToString();
                }
                if (row["Content"] != null)
                {
                    model.Content = row["Content"].ToString();
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
            strSql.Append("select ID,Ename,Name,Types,Content ");
            strSql.Append(" FROM TcConfig ");
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