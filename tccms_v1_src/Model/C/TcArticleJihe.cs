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
	 	//TcArticleJihe
		public partial class TcArticleJihe
	{
	public TcArticleJihe(){
	    					 _id=0;
	    					 _articleid=0;
	    					 _s1="";
	    					 _s2="";
	    					 _s3="";
	    					 _s4="";
	    					 _s5="";
	    					 _s6="";
	    					 _s7="";
	    					 _s8="";
	    					 _s9="";
	    					 _s10="";
	    				    _addtime=new DateTime(1900,1,1);

				
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
		/// S6
        /// </summary>
		private string _s6;
        public string S6
        {
            get{return _s6; }
            set{ _s6 = value; }
        }
		/// <summary>
		/// S7
        /// </summary>
		private string _s7;
        public string S7
        {
            get{return _s7; }
            set{ _s7 = value; }
        }
		/// <summary>
		/// S8
        /// </summary>
		private string _s8;
        public string S8
        {
            get{return _s8; }
            set{ _s8 = value; }
        }
		/// <summary>
		/// S9
        /// </summary>
		private string _s9;
        public string S9
        {
            get{return _s9; }
            set{ _s9 = value; }
        }
		/// <summary>
		/// S10
        /// </summary>
		private string _s10;
        public string S10
        {
            get{return _s10; }
            set{ _s10 = value; }
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
		
	}
}