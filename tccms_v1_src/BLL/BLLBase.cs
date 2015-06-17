using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
* Copyright (c) 2013-2020 Tuichu.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:599906561  email: 599906561@qq.com
*│  QQ群： 2068911
*│　版权所有：推出网版权所有 http://www.tuichu.net　
*└──────────────────────────────────┘
*/

namespace Tc.BLL
{
    public class BLLBase<T> where T : BLLBase<T>, new()
    {
        private static T s_Instance = null;

        /// <summary>
        /// 获取当前业务逻辑对象的实例
        /// </summary>
        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new T();
                }
                return s_Instance;
            }
        }
    }
}