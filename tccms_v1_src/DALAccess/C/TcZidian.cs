﻿/**
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
    /// 数据访问类:TcZidian
    /// </summary>
    public partial class TcZidian
    {
        public TcZidian()
        { }

        #region BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperOleDb.GetMaxID("ID", "TcZidian");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TcZidian");
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
        public int Add(Tc.Model.TcZidian model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TcZidian(");
            strSql.Append("Name,Types,Paixu,Pid)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Types,@Paixu,@Pid)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Types", OleDbType.VarChar,255),
					new OleDbParameter("@Paixu", OleDbType.Integer,4),
					new OleDbParameter("@Pid", OleDbType.Integer,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Types;
            parameters[2].Value = model.Paixu;
            parameters[3].Value = model.Pid;

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
        public bool Update(Tc.Model.TcZidian model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TcZidian set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Types=@Types,");
            strSql.Append("Paixu=@Paixu,");
            strSql.Append("Pid=@Pid");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Types", OleDbType.VarChar,255),
					new OleDbParameter("@Paixu", OleDbType.Integer,4),
					new OleDbParameter("@Pid", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Types;
            parameters[2].Value = model.Paixu;
            parameters[3].Value = model.Pid;
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
            strSql.Append("delete from TcZidian ");
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
            strSql.Append("delete from TcZidian ");
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
        public Tc.Model.TcZidian GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Name,Types,Paixu,Pid from TcZidian ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            Tc.Model.TcZidian model = new Tc.Model.TcZidian();
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
        public Tc.Model.TcZidian DataRowToModel(DataRow row)
        {
            Tc.Model.TcZidian model = new Tc.Model.TcZidian();
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
                if (row["Types"] != null)
                {
                    model.Types = row["Types"].ToString();
                }
                if (row["Paixu"] != null && row["Paixu"].ToString() != "")
                {
                    model.Paixu = int.Parse(row["Paixu"].ToString());
                }
                if (row["Pid"] != null && row["Pid"].ToString() != "")
                {
                    model.Pid = int.Parse(row["Pid"].ToString());
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
            strSql.Append("select ID,Name,Types,Paixu,Pid ");
            strSql.Append(" FROM TcZidian ");
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