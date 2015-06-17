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
    //TcHuandeng
    public partial class TcHuandeng
    {
        public TcHuandeng()
        {
            _id = 0;
            _types = "";
            _title = "";
            _tupian = "";
            _shuoming = "";
            _url = "";
            _paixu = 0;
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
        /// Types
        /// </summary>
        private string _types;

        public string Types
        {
            get { return _types; }
            set { _types = value; }
        }

        /// <summary>
        /// Title
        /// </summary>
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Tupian
        /// </summary>
        private string _tupian;

        public string Tupian
        {
            get { return _tupian; }
            set { _tupian = value; }
        }

        /// <summary>
        /// Shuoming
        /// </summary>
        private string _shuoming;

        public string Shuoming
        {
            get { return _shuoming; }
            set { _shuoming = value; }
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
        /// Paixu
        /// </summary>
        private int? _paixu;

        public int? Paixu
        {
            get { return _paixu; }
            set { _paixu = value; }
        }
    }
}