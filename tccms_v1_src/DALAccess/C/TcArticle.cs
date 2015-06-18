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
    /// 数据访问类:TcArticle
    /// </summary>
    public partial class TcArticle
    {
        public TcArticle()
        { }

        #region BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperOleDb.GetMaxID("ID", "TcArticle");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TcArticle");
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
        public int Add(Tc.Model.TcArticle model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TcArticle(");
            strSql.Append("Fenleiid,Title,Types,Jianyao,Tupian,Shipin,Url,Content,Click,AddUser,Addtime,Color,IsTuijian,IsTop,SeoTitle,SeoKeyword,SeoDescription)");
            strSql.Append(" values (");
            strSql.Append("@Fenleiid,@Title,@Types,@Jianyao,@Tupian,@Shipin,@Url,@Content,@Click,@AddUser,@Addtime,@Color,@IsTuijian,@IsTop,@SeoTitle,@SeoKeyword,@SeoDescription)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Fenleiid", OleDbType.Integer,4),
					new OleDbParameter("@Title", OleDbType.VarChar,255),
					new OleDbParameter("@Types", OleDbType.VarChar,255),
					new OleDbParameter("@Jianyao", OleDbType.VarChar,255),
					new OleDbParameter("@Tupian", OleDbType.VarChar,255),
					new OleDbParameter("@Shipin", OleDbType.VarChar,255),
					new OleDbParameter("@Url", OleDbType.VarChar,255),
					new OleDbParameter("@Content", OleDbType.VarChar,0),
					new OleDbParameter("@Click", OleDbType.Integer,4),
					new OleDbParameter("@AddUser", OleDbType.Integer,4),
					new OleDbParameter("@Addtime", OleDbType.Date),
					new OleDbParameter("@Color", OleDbType.VarChar,255),
					new OleDbParameter("@IsTuijian", OleDbType.Integer,4),
					new OleDbParameter("@IsTop", OleDbType.Integer,4),
					new OleDbParameter("@SeoTitle", OleDbType.VarChar,255),
					new OleDbParameter("@SeoKeyword", OleDbType.VarChar,255),
					new OleDbParameter("@SeoDescription", OleDbType.VarChar,255)};
            parameters[0].Value = model.Fenleiid;
            parameters[1].Value = model.Title;
            parameters[2].Value = model.Types;
            parameters[3].Value = model.Jianyao;
            parameters[4].Value = model.Tupian;
            parameters[5].Value = model.Shipin;
            parameters[6].Value = model.Url;
            parameters[7].Value = model.Content;
            parameters[8].Value = model.Click;
            parameters[9].Value = model.AddUser;
            parameters[10].Value = model.Addtime;
            parameters[11].Value = model.Color;
            parameters[12].Value = model.IsTuijian;
            parameters[13].Value = model.IsTop;
            parameters[14].Value = model.SeoTitle;
            parameters[15].Value = model.SeoKeyword;
            parameters[16].Value = model.SeoDescription;

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
        public bool Update(Tc.Model.TcArticle model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TcArticle set ");
            strSql.Append("Fenleiid=@Fenleiid,");
            strSql.Append("Title=@Title,");
            strSql.Append("Types=@Types,");
            strSql.Append("Jianyao=@Jianyao,");
            strSql.Append("Tupian=@Tupian,");
            strSql.Append("Shipin=@Shipin,");
            strSql.Append("Url=@Url,");
            strSql.Append("Content=@Content,");
            strSql.Append("Click=@Click,");
            strSql.Append("AddUser=@AddUser,");
            strSql.Append("Addtime=@Addtime,");
            strSql.Append("Color=@Color,");
            strSql.Append("IsTuijian=@IsTuijian,");
            strSql.Append("IsTop=@IsTop,");
            strSql.Append("SeoTitle=@SeoTitle,");
            strSql.Append("SeoKeyword=@SeoKeyword,");
            strSql.Append("SeoDescription=@SeoDescription");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Fenleiid", OleDbType.Integer,4),
					new OleDbParameter("@Title", OleDbType.VarChar,255),
					new OleDbParameter("@Types", OleDbType.VarChar,255),
					new OleDbParameter("@Jianyao", OleDbType.VarChar,255),
					new OleDbParameter("@Tupian", OleDbType.VarChar,255),
					new OleDbParameter("@Shipin", OleDbType.VarChar,255),
					new OleDbParameter("@Url", OleDbType.VarChar,255),
					new OleDbParameter("@Content", OleDbType.VarChar,0),
					new OleDbParameter("@Click", OleDbType.Integer,4),
					new OleDbParameter("@AddUser", OleDbType.Integer,4),
					new OleDbParameter("@Addtime", OleDbType.Date),
					new OleDbParameter("@Color", OleDbType.VarChar,255),
					new OleDbParameter("@IsTuijian", OleDbType.Integer,4),
					new OleDbParameter("@IsTop", OleDbType.Integer,4),
					new OleDbParameter("@SeoTitle", OleDbType.VarChar,255),
					new OleDbParameter("@SeoKeyword", OleDbType.VarChar,255),
					new OleDbParameter("@SeoDescription", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.Fenleiid;
            parameters[1].Value = model.Title;
            parameters[2].Value = model.Types;
            parameters[3].Value = model.Jianyao;
            parameters[4].Value = model.Tupian;
            parameters[5].Value = model.Shipin;
            parameters[6].Value = model.Url;
            parameters[7].Value = model.Content;
            parameters[8].Value = model.Click;
            parameters[9].Value = model.AddUser;
            parameters[10].Value = model.Addtime;
            parameters[11].Value = model.Color;
            parameters[12].Value = model.IsTuijian;
            parameters[13].Value = model.IsTop;
            parameters[14].Value = model.SeoTitle;
            parameters[15].Value = model.SeoKeyword;
            parameters[16].Value = model.SeoDescription;
            parameters[17].Value = model.ID;

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
            strSql.Append("delete from TcArticle ");
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
            strSql.Append("delete from TcArticle ");
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
        public Tc.Model.TcArticle GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Fenleiid,Title,Types,Jianyao,Tupian,Shipin,Url,Content,Click,AddUser,Addtime,Color,IsTuijian,IsTop,SeoTitle,SeoKeyword,SeoDescription from TcArticle ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            Tc.Model.TcArticle model = new Tc.Model.TcArticle();
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
        public Tc.Model.TcArticle DataRowToModel(DataRow row)
        {
            Tc.Model.TcArticle model = new Tc.Model.TcArticle();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Fenleiid"] != null && row["Fenleiid"].ToString() != "")
                {
                    model.Fenleiid = int.Parse(row["Fenleiid"].ToString());
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["Types"] != null)
                {
                    model.Types = row["Types"].ToString();
                }
                if (row["Jianyao"] != null)
                {
                    model.Jianyao = row["Jianyao"].ToString();
                }
                if (row["Tupian"] != null)
                {
                    model.Tupian = row["Tupian"].ToString();
                }
                if (row["Shipin"] != null)
                {
                    model.Shipin = row["Shipin"].ToString();
                }
                if (row["Url"] != null)
                {
                    model.Url = row["Url"].ToString();
                }
                if (row["Content"] != null)
                {
                    model.Content = row["Content"].ToString();
                }
                if (row["Click"] != null && row["Click"].ToString() != "")
                {
                    model.Click = int.Parse(row["Click"].ToString());
                }
                if (row["AddUser"] != null && row["AddUser"].ToString() != "")
                {
                    model.AddUser = int.Parse(row["AddUser"].ToString());
                }
                if (row["Addtime"] != null && row["Addtime"].ToString() != "")
                {
                    model.Addtime = DateTime.Parse(row["Addtime"].ToString());
                }
                if (row["Color"] != null)
                {
                    model.Color = row["Color"].ToString();
                }
                if (row["IsTuijian"] != null && row["IsTuijian"].ToString() != "")
                {
                    model.IsTuijian = int.Parse(row["IsTuijian"].ToString());
                }
                if (row["IsTop"] != null && row["IsTop"].ToString() != "")
                {
                    model.IsTop = int.Parse(row["IsTop"].ToString());
                }
                if (row["SeoTitle"] != null)
                {
                    model.SeoTitle = row["SeoTitle"].ToString();
                }
                if (row["SeoKeyword"] != null)
                {
                    model.SeoKeyword = row["SeoKeyword"].ToString();
                }
                if (row["SeoDescription"] != null)
                {
                    model.SeoDescription = row["SeoDescription"].ToString();
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
            strSql.Append("select ID,Fenleiid,Title,Types,Jianyao,Tupian,Shipin,Url,Content,Click,AddUser,Addtime,Color,IsTuijian,IsTop,SeoTitle,SeoKeyword,SeoDescription ");
            strSql.Append(" FROM TcArticle ");
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