/**
* Copyright (c) 2013-2020 Tuichu.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:59990-6-5-6-1  email: 599906561@qq.com
*│　版权所有：推出网版权所有 http://tuichu.net
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
    /// 数据访问类:TcLiuyan
    /// </summary>
    public partial class TcLiuyan
    {
        public TcLiuyan()
        { }

        #region BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperOleDb.GetMaxID("ID", "TcLiuyan");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TcLiuyan");
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
        public int Add(Tc.Model.TcLiuyan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TcLiuyan(");
            strSql.Append("Xingming,QQ,GongsiMc,Email,Dianhua,Dizhi,Neirong,RukuSj)");
            strSql.Append(" values (");
            strSql.Append("@Xingming,@QQ,@GongsiMc,@Email,@Dianhua,@Dizhi,@Neirong,@RukuSj)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Xingming", OleDbType.VarChar,255),
					new OleDbParameter("@QQ", OleDbType.VarChar,255),
					new OleDbParameter("@GongsiMc", OleDbType.VarChar,255),
					new OleDbParameter("@Email", OleDbType.VarChar,255),
					new OleDbParameter("@Dianhua", OleDbType.VarChar,255),
					new OleDbParameter("@Dizhi", OleDbType.VarChar,255),
					new OleDbParameter("@Neirong", OleDbType.VarChar,0),
					new OleDbParameter("@RukuSj", OleDbType.Date)};
            parameters[0].Value = model.Xingming;
            parameters[1].Value = model.QQ;
            parameters[2].Value = model.GongsiMc;
            parameters[3].Value = model.Email;
            parameters[4].Value = model.Dianhua;
            parameters[5].Value = model.Dizhi;
            parameters[6].Value = model.Neirong;
            parameters[7].Value = model.RukuSj;

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
        public bool Update(Tc.Model.TcLiuyan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TcLiuyan set ");
            strSql.Append("Xingming=@Xingming,");
            strSql.Append("QQ=@QQ,");
            strSql.Append("GongsiMc=@GongsiMc,");
            strSql.Append("Email=@Email,");
            strSql.Append("Dianhua=@Dianhua,");
            strSql.Append("Dizhi=@Dizhi,");
            strSql.Append("Neirong=@Neirong,");
            strSql.Append("RukuSj=@RukuSj");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Xingming", OleDbType.VarChar,255),
					new OleDbParameter("@QQ", OleDbType.VarChar,255),
					new OleDbParameter("@GongsiMc", OleDbType.VarChar,255),
					new OleDbParameter("@Email", OleDbType.VarChar,255),
					new OleDbParameter("@Dianhua", OleDbType.VarChar,255),
					new OleDbParameter("@Dizhi", OleDbType.VarChar,255),
					new OleDbParameter("@Neirong", OleDbType.VarChar,0),
					new OleDbParameter("@RukuSj", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.Xingming;
            parameters[1].Value = model.QQ;
            parameters[2].Value = model.GongsiMc;
            parameters[3].Value = model.Email;
            parameters[4].Value = model.Dianhua;
            parameters[5].Value = model.Dizhi;
            parameters[6].Value = model.Neirong;
            parameters[7].Value = model.RukuSj;
            parameters[8].Value = model.ID;

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
            strSql.Append("delete from TcLiuyan ");
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
            strSql.Append("delete from TcLiuyan ");
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
        public Tc.Model.TcLiuyan GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Xingming,QQ,GongsiMc,Email,Dianhua,Dizhi,Neirong,RukuSj from TcLiuyan ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            Tc.Model.TcLiuyan model = new Tc.Model.TcLiuyan();
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
        public Tc.Model.TcLiuyan DataRowToModel(DataRow row)
        {
            Tc.Model.TcLiuyan model = new Tc.Model.TcLiuyan();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Xingming"] != null)
                {
                    model.Xingming = row["Xingming"].ToString();
                }
                if (row["QQ"] != null)
                {
                    model.QQ = row["QQ"].ToString();
                }
                if (row["GongsiMc"] != null)
                {
                    model.GongsiMc = row["GongsiMc"].ToString();
                }
                if (row["Email"] != null)
                {
                    model.Email = row["Email"].ToString();
                }
                if (row["Dianhua"] != null)
                {
                    model.Dianhua = row["Dianhua"].ToString();
                }
                if (row["Dizhi"] != null)
                {
                    model.Dizhi = row["Dizhi"].ToString();
                }
                if (row["Neirong"] != null)
                {
                    model.Neirong = row["Neirong"].ToString();
                }
                if (row["RukuSj"] != null && row["RukuSj"].ToString() != "")
                {
                    model.RukuSj = DateTime.Parse(row["RukuSj"].ToString());
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
            strSql.Append("select ID,Xingming,QQ,GongsiMc,Email,Dianhua,Dizhi,Neirong,RukuSj ");
            strSql.Append(" FROM TcLiuyan ");
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