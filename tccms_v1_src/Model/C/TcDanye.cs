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
    //TcDanye
    public partial class TcDanye
    {
        public TcDanye()
        {
            _id = 0;
            _ename = "";
            _types = "";
            _name = "";
            _url = "";
            _tupian = "";
            _fenlei = 0;
            _content = "";
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
        /// Ename
        /// </summary>
        private string _ename;

        public string Ename
        {
            get { return _ename; }
            set { _ename = value; }
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
        /// Name
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        /// Tupian
        /// </summary>
        private string _tupian;

        public string Tupian
        {
            get { return _tupian; }
            set { _tupian = value; }
        }

        /// <summary>
        /// Fenlei
        /// </summary>
        private int? _fenlei;

        public int? Fenlei
        {
            get { return _fenlei; }
            set { _fenlei = value; }
        }

        /// <summary>
        /// Content
        /// </summary>
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}