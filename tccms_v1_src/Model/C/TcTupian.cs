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
    //TcTupian
    public partial class TcTupian
    {
        public TcTupian()
        {
            _id = 0;
            _articleid = 0;
            _title = "";
            _tupian = "";
            _content = "";
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
        /// Articleid
        /// </summary>
        private int? _articleid;

        public int? Articleid
        {
            get { return _articleid; }
            set { _articleid = value; }
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
        /// Content
        /// </summary>
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
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