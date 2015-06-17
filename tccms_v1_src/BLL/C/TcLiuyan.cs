/** 
* Copyright (c) 2013-2020 Tuichu.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:599906561  email: 599906561@qq.com
*│  QQ群： 2068911
*│　版权所有：推出网版权所有 http://www.tuichu.net　
*└──────────────────────────────────┘
*/
using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Tc.Model;
namespace Tc.BLL {
	 	//TcLiuyan
		public partial class TcLiuyan:BLLBase<TcLiuyan>
	{
   		     
		private readonly Tc.DAL.TcLiuyan dal=new Tc.DAL.TcLiuyan();
		public TcLiuyan()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Tc.Model.TcLiuyan model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tc.Model.TcLiuyan model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tc.Model.TcLiuyan GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tc.Model.TcLiuyan> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tc.Model.TcLiuyan> DataTableToList(DataTable dt)
		{
			List<Tc.Model.TcLiuyan> modelList = new List<Tc.Model.TcLiuyan>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tc.Model.TcLiuyan model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Tc.Model.TcLiuyan();					
													if(dt.Rows[n]["ID"].ToString()!="")
				{
					model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
				}
																																				model.Xingming= dt.Rows[n]["Xingming"].ToString();
																																model.QQ= dt.Rows[n]["QQ"].ToString();
																																model.GongsiMc= dt.Rows[n]["GongsiMc"].ToString();
																																model.Email= dt.Rows[n]["Email"].ToString();
																																model.Dianhua= dt.Rows[n]["Dianhua"].ToString();
																																model.Dizhi= dt.Rows[n]["Dizhi"].ToString();
																																model.Neirong= dt.Rows[n]["Neirong"].ToString();
																												if(dt.Rows[n]["RukuSj"].ToString()!="")
				{
					model.RukuSj=DateTime.Parse(dt.Rows[n]["RukuSj"].ToString());
				}
																										
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
		
		#endregion
   
	}
}