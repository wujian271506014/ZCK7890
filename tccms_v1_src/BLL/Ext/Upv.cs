using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Tc.BLL
{
    public class TcUpv : BLLBase<TcUpv>
    {
        /// <summary>
        /// 1.0升级2.0，更新数据库
        /// </summary>
        /// <returns></returns>
        public int ToV2()
        {
            return new Tc.DAL.TcUpv().ToV2();
        }
    }
}