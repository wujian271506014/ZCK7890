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
    /// 数据访问类:TcAdmin
    /// </summary>
    public partial class TcAdmin
    {
        public TcAdmin()
        { }

        #region BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperOleDb.GetMaxID("ID", "TcAdmin");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TcAdmin");
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
        public int Add(Tc.Model.TcAdmin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TcAdmin(");
            strSql.Append("Name,Pwd,Role)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Pwd,@Role)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Pwd", OleDbType.VarChar,255),
					new OleDbParameter("@Role", OleDbType.Integer,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Pwd;
            parameters[2].Value = model.Role;

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
        public bool Update(Tc.Model.TcAdmin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TcAdmin set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Pwd=@Pwd,");
            strSql.Append("Role=@Role");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Pwd", OleDbType.VarChar,255),
					new OleDbParameter("@Role", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Pwd;
            parameters[2].Value = model.Role;
            parameters[3].Value = model.ID;

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
            strSql.Append("delete from TcAdmin ");
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
            strSql.Append("delete from TcAdmin ");
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
        public Tc.Model.TcAdmin GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Name,Pwd,Role from TcAdmin ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            Tc.Model.TcAdmin model = new Tc.Model.TcAdmin();
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
        public Tc.Model.TcAdmin DataRowToModel(DataRow row)
        {
            Tc.Model.TcAdmin model = new Tc.Model.TcAdmin();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Pwd"] != null)
                {
                    model.Pwd = row["Pwd"].ToString();
                }
                if (row["Role"] != null && row["Role"].ToString() != "")
                {
                    model.Role = int.Parse(row["Role"].ToString());
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
            strSql.Append("select ID,Name,Pwd,Role ");
            strSql.Append(" FROM TcAdmin ");
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