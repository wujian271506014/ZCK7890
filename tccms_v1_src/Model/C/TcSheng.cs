﻿/**
* Copyright (c) 2013-2020 WuJian.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:88199107  email: 88199107@qq.com
*│　版权所有：吴键　│
*└──────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Tc.Model
{
    //TcSheng
    public partial class TcSheng
    {
        public TcSheng()
        {
            _id = 0;
            _code = "";
            _name = "";
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
        /// Code
        /// </summary>
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
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