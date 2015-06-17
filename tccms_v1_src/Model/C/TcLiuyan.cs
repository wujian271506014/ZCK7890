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
	 	//TcLiuyan
		public partial class TcLiuyan
	{
	public TcLiuyan(){
	    					 _id=0;
	    					 _xingming="";
	    					 _qq="";
	    					 _gongsimc="";
	    					 _email="";
	    					 _dianhua="";
	    					 _dizhi="";
	    					 _neirong="";
	    				    _rukusj=new DateTime(1900,1,1);

				
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
		/// Xingming
        /// </summary>
		private string _xingming;
        public string Xingming
        {
            get{return _xingming; }
            set{ _xingming = value; }
        }
		/// <summary>
		/// QQ
        /// </summary>
		private string _qq;
        public string QQ
        {
            get{return _qq; }
            set{ _qq = value; }
        }
		/// <summary>
		/// GongsiMc
        /// </summary>
		private string _gongsimc;
        public string GongsiMc
        {
            get{return _gongsimc; }
            set{ _gongsimc = value; }
        }
		/// <summary>
		/// Email
        /// </summary>
		private string _email;
        public string Email
        {
            get{return _email; }
            set{ _email = value; }
        }
		/// <summary>
		/// Dianhua
        /// </summary>
		private string _dianhua;
        public string Dianhua
        {
            get{return _dianhua; }
            set{ _dianhua = value; }
        }
		/// <summary>
		/// Dizhi
        /// </summary>
		private string _dizhi;
        public string Dizhi
        {
            get{return _dizhi; }
            set{ _dizhi = value; }
        }
		/// <summary>
		/// Neirong
        /// </summary>
		private string _neirong;
        public string Neirong
        {
            get{return _neirong; }
            set{ _neirong = value; }
        }
		/// <summary>
		/// RukuSj
        /// </summary>
		private DateTime _rukusj;
        public DateTime RukuSj
        {
            get{return _rukusj; }
            set{ _rukusj = value; }
        }
		
	}
}