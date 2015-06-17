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
    //TcArticle
    public partial class TcArticle
    {
        public TcArticle()
        {
            _id = 0;
            _fenleiid = 0;
            _title = "";
            _types = "";
            _jianyao = "";
            _tupian = "";
            _shipin = "";
            _url = "";
            _content = "";
            _click = 0;
            _adduser = 0;
            _addtime = new DateTime(1900, 1, 1);

            _color = "";
            _istuijian = 0;
            _istop = 0;
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
        /// Fenleiid
        /// </summary>
        private int? _fenleiid;

        public int? Fenleiid
        {
            get { return _fenleiid; }
            set { _fenleiid = value; }
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
        /// Types
        /// </summary>
        private string _types;

        public string Types
        {
            get { return _types; }
            set { _types = value; }
        }

        /// <summary>
        /// Jianyao
        /// </summary>
        private string _jianyao;

        public string Jianyao
        {
            get { return _jianyao; }
            set { _jianyao = value; }
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
        /// Shipin
        /// </summary>
        private string _shipin;

        public string Shipin
        {
            get { return _shipin; }
            set { _shipin = value; }
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
        /// Content
        /// </summary>
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        /// <summary>
        /// Click
        /// </summary>
        private int? _click;

        public int? Click
        {
            get { return _click; }
            set { _click = value; }
        }

        /// <summary>
        /// AddUser
        /// </summary>
        private int? _adduser;

        public int? AddUser
        {
            get { return _adduser; }
            set { _adduser = value; }
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

        /// <summary>
        /// Color
        /// </summary>
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// IsTuijian
        /// </summary>
        private int? _istuijian;

        public int? IsTuijian
        {
            get { return _istuijian; }
            set { _istuijian = value; }
        }

        /// <summary>
        /// IsTop
        /// </summary>
        private int? _istop;

        public int? IsTop
        {
            get { return _istop; }
            set { _istop = value; }
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