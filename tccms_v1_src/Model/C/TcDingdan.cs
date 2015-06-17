/** 
* Copyright (c) 2013-2020 Tuichu.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:599906561  email: 599906561@qq.com
*│　版权所有：推出网版权所有(http://www.tuichu.net)　│
*└──────────────────────────────────┘
*/
using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Tc.Model{
	 	//TcDingdan
		public partial class TcDingdan
	{
	public TcDingdan(){
	    					 _id=0;
	    					 _title="";
	    					 _zongjia=0;
	    					 _zhuangtai=0;
	    					 _adminid=0;
	    					 _shouhuoren="";
	    					 _shouhuodianhua="";
	    					 _shouhuodizhi="";
	    					 _shouhuoemail="";
	    					 _beizhu="";
	    				    _addtime=new DateTime(1900,1,1);

							 _s1="";
	    					 _s2="";
	    					 _s3="";
	    					 _s4="";
	    					 _s5="";
	    					 _t1="";
	    					 _t2="";
	    		
	}

      	/// <summary>
		/// ID
        /// </summary>
		private int _id;
        public int ID
        {
            get{return _id; }
            set{ _id = value; }
        }
		/// <summary>
		/// Title
        /// </summary>
		private string _title;
        public string Title
        {
            get{return _title; }
            set{ _title = value; }
        }
		/// <summary>
		/// Zongjia
        /// </summary>
		private decimal _zongjia;
        public decimal Zongjia
        {
            get{return _zongjia; }
            set{ _zongjia = value; }
        }
		/// <summary>
		/// Zhuangtai
        /// </summary>
		private int _zhuangtai;
        public int Zhuangtai
        {
            get{return _zhuangtai; }
            set{ _zhuangtai = value; }
        }
		/// <summary>
		/// Adminid
        /// </summary>
		private int _adminid;
        public int Adminid
        {
            get{return _adminid; }
            set{ _adminid = value; }
        }
		/// <summary>
		/// Shouhuoren
        /// </summary>
		private string _shouhuoren;
        public string Shouhuoren
        {
            get{return _shouhuoren; }
            set{ _shouhuoren = value; }
        }
		/// <summary>
		/// ShouhuoDianhua
        /// </summary>
		private string _shouhuodianhua;
        public string ShouhuoDianhua
        {
            get{return _shouhuodianhua; }
            set{ _shouhuodianhua = value; }
        }
		/// <summary>
		/// ShouhuoDizhi
        /// </summary>
		private string _shouhuodizhi;
        public string ShouhuoDizhi
        {
            get{return _shouhuodizhi; }
            set{ _shouhuodizhi = value; }
        }
		/// <summary>
		/// ShouhuoEmail
        /// </summary>
		private string _shouhuoemail;
        public string ShouhuoEmail
        {
            get{return _shouhuoemail; }
            set{ _shouhuoemail = value; }
        }
		/// <summary>
		/// Beizhu
        /// </summary>
		private string _beizhu;
        public string Beizhu
        {
            get{return _beizhu; }
            set{ _beizhu = value; }
        }
		/// <summary>
		/// Addtime
        /// </summary>
		private DateTime _addtime;
        public DateTime Addtime
        {
            get{return _addtime; }
            set{ _addtime = value; }
        }
		/// <summary>
		/// S1
        /// </summary>
		private string _s1;
        public string S1
        {
            get{return _s1; }
            set{ _s1 = value; }
        }
		/// <summary>
		/// S2
        /// </summary>
		private string _s2;
        public string S2
        {
            get{return _s2; }
            set{ _s2 = value; }
        }
		/// <summary>
		/// S3
        /// </summary>
		private string _s3;
        public string S3
        {
            get{return _s3; }
            set{ _s3 = value; }
        }
		/// <summary>
		/// S4
        /// </summary>
		private string _s4;
        public string S4
        {
            get{return _s4; }
            set{ _s4 = value; }
        }
		/// <summary>
		/// S5
        /// </summary>
		private string _s5;
        public string S5
        {
            get{return _s5; }
            set{ _s5 = value; }
        }
		/// <summary>
		/// T1
        /// </summary>
		private string _t1;
        public string T1
        {
            get{return _t1; }
            set{ _t1 = value; }
        }
		/// <summary>
		/// T2
        /// </summary>
		private string _t2;
        public string T2
        {
            get{return _t2; }
            set{ _t2 = value; }
        }
		
	}
}