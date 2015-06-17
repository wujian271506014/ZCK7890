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
	 	//TcDingdanChanpin
		public partial class TcDingdanChanpin
	{
	public TcDingdanChanpin(){
	    					 _id=0;
	    					 _articleid=0;
	    					 _title="";
	    					 _jiage=0;
	    					 _zongjia=0;
	    					 _shuliang=0;
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
		/// Articleid
        /// </summary>
		private int _articleid;
        public int Articleid
        {
            get{return _articleid; }
            set{ _articleid = value; }
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
		/// Jiage
        /// </summary>
		private decimal _jiage;
        public decimal Jiage
        {
            get{return _jiage; }
            set{ _jiage = value; }
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
		/// Shuliang
        /// </summary>
		private int _shuliang;
        public int Shuliang
        {
            get{return _shuliang; }
            set{ _shuliang = value; }
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