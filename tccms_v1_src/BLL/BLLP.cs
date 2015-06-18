using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

/**
* Copyright (c) 2013-2020 WuJian.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:88199107  email: 88199107@qq.com
*│  QQ群： 234978966
*│　版权所有：吴健
*└──────────────────────────────────┘
*/

namespace Tc.BLL
{
    public class BLLP : BLLBase<BLLP>
    {
        public DataTable Get_Page_List(string tablename, string orderby, int startrecordindex, int pagesize, string where, out int sumcount)
        {
            Tc.DAL.DALP dal = new DAL.DALP();
            return dal.Get_Page_List(tablename, orderby, startrecordindex, pagesize, where, out sumcount);
        }
    }
}