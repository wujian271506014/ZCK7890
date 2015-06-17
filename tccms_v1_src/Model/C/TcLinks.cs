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
    //TcLinks
    public partial class TcLinks
    {
        public TcLinks()
        {
            _id = 0;
            _name = "";
            _types = "";
            _url = "";
            _logourl = "";
            _paixu = 0;
            _isxianshi = 0;
            _addtime = new DateTime(1900, 1, 1);
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
        /// Url
        /// </summary>
        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// LogoUrl
        /// </summary>
        private string _logourl;

        public string LogoUrl
        {
            get { return _logourl; }
            set { _logourl = value; }
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
        /// IsXianshi
        /// </summary>
        private int? _isxianshi;

        public int? IsXianshi
        {
            get { return _isxianshi; }
            set { _isxianshi = value; }
        }

        /// <summary>
        /// Addtime
        /// </summary>
        private DateTime? _addtime;

        public DateTime? Addtime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }
    }
}