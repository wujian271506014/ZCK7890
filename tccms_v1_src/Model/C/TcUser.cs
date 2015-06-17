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
	 	//TcUser
		public partial class TcUser
	{
	public TcUser(){
	    					 _id=0;
	    					 _adminid=0;
	    				    _addtime=new DateTime(1900,1,1);

						    _zuihoudlsj=new DateTime(1900,1,1);

							 _email="";
	    					 _beizhu="";
	    					 _xingming="";
	    					 _sex=0;
	    					 _dizhi="";
	    					 _youbian="";
	    					 _danwei="";
	    					 _dianhua="";
	    					 _shouji="";
	    					 _shenfenzheng="";
	    					 _chushengrq="";
	    					 _sheng="";
	    					 _shi="";
	    					 _quxian="";
	    					 _jiguan="";
	    					 _jifen=0;
	    					 _touxiang="";
	    					 _jieshao="";
	    		
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
		/// Adminid
        /// </summary>
		private int _adminid;
        public int Adminid
        {
            get{return _adminid; }
            set{ _adminid = value; }
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
		/// ZuihouDlsj
        /// </summary>
		private DateTime _zuihoudlsj;
        public DateTime ZuihouDlsj
        {
            get{return _zuihoudlsj; }
            set{ _zuihoudlsj = value; }
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
		/// Beizhu
        /// </summary>
		private string _beizhu;
        public string Beizhu
        {
            get{return _beizhu; }
            set{ _beizhu = value; }
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
		/// Sex
        /// </summary>
		private int _sex;
        public int Sex
        {
            get{return _sex; }
            set{ _sex = value; }
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
		/// Youbian
        /// </summary>
		private string _youbian;
        public string Youbian
        {
            get{return _youbian; }
            set{ _youbian = value; }
        }
		/// <summary>
		/// Danwei
        /// </summary>
		private string _danwei;
        public string Danwei
        {
            get{return _danwei; }
            set{ _danwei = value; }
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
		/// Shouji
        /// </summary>
		private string _shouji;
        public string Shouji
        {
            get{return _shouji; }
            set{ _shouji = value; }
        }
		/// <summary>
		/// Shenfenzheng
        /// </summary>
		private string _shenfenzheng;
        public string Shenfenzheng
        {
            get{return _shenfenzheng; }
            set{ _shenfenzheng = value; }
        }
		/// <summary>
		/// ChushengRq
        /// </summary>
		private string _chushengrq;
        public string ChushengRq
        {
            get{return _chushengrq; }
            set{ _chushengrq = value; }
        }
		/// <summary>
		/// Sheng
        /// </summary>
		private string _sheng;
        public string Sheng
        {
            get{return _sheng; }
            set{ _sheng = value; }
        }
		/// <summary>
		/// Shi
        /// </summary>
		private string _shi;
        public string Shi
        {
            get{return _shi; }
            set{ _shi = value; }
        }
		/// <summary>
		/// Quxian
        /// </summary>
		private string _quxian;
        public string Quxian
        {
            get{return _quxian; }
            set{ _quxian = value; }
        }
		/// <summary>
		/// Jiguan
        /// </summary>
		private string _jiguan;
        public string Jiguan
        {
            get{return _jiguan; }
            set{ _jiguan = value; }
        }
		/// <summary>
		/// Jifen
        /// </summary>
		private decimal _jifen;
        public decimal Jifen
        {
            get{return _jifen; }
            set{ _jifen = value; }
        }
		/// <summary>
		/// Touxiang
        /// </summary>
		private string _touxiang;
        public string Touxiang
        {
            get{return _touxiang; }
            set{ _touxiang = value; }
        }
		/// <summary>
		/// Jieshao
        /// </summary>
		private string _jieshao;
        public string Jieshao
        {
            get{return _jieshao; }
            set{ _jieshao = value; }
        }
		
	}
}