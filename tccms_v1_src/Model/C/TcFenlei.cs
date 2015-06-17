/**
* Copyright (c) 2013-2020 Tuichu.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:599906561  email: 599906561@qq.com
*│　版权所有：推出网版权所有(http://www.tuichu.net)　│
*└──────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Tc.Model
{
    //TcFenlei
    public partial class TcFenlei
    {
        public TcFenlei()
        {
            _id = 0;
            _name = "";
            _types = "";
            _pid = 0;
            _paixu = 0;
            _url = "";
            _miaoshu = "";
            _seotitle = "";
            _seokeyword = "";
            _seodescription = "";
        }

        /// <summary>
        /// ID
        /// </summary>
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Name
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Types
        /// </summary>
        private string _types;

        public string Types
        {
            get { return _types; }
            set { _types = value; }
        }

        /// <summary>
        /// Pid
        /// </summary>
        private int? _pid;

        public int? Pid
        {
            get { return _pid; }
            set { _pid = value; }
        }

        /// <summary>
        /// Paixu
        /// </summary>
        private int? _paixu;

        public int? Paixu
        {
            get { return _paixu; }
            set { _paixu = value; }
        }

        /// <summary>
        /// Url
        /// </summary>
        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// Miaoshu
        /// </summary>
        private string _miaoshu;

        public string Miaoshu
        {
            get { return _miaoshu; }
            set { _miaoshu = value; }
        }

        /// <summary>
        /// SeoTitle
        /// </summary>
        private string _seotitle;

        public string SeoTitle
        {
            get { return _seotitle; }
            set { _seotitle = value; }
        }

        /// <summary>
        /// SeoKeyword
        /// </summary>
        private string _seokeyword;

        public string SeoKeyword
        {
            get { return _seokeyword; }
            set { _seokeyword = value; }
        }

        /// <summary>
        /// SeoDescription
        /// </summary>
        private string _seodescription;

        public string SeoDescription
        {
            get { return _seodescription; }
            set { _seodescription = value; }
        }
    }
}