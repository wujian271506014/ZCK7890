using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tc
{
    public class AdminBase : System.Web.UI.Page
    {
        #region 当前登陆的管理员

        private int? _MyId;

        /// <summary>
        /// 当前登陆用户id
        /// </summary>
        protected int MyId
        {
            get
            {
                if (!_MyId.HasValue)
                {
                    _MyId = LibAdmin.GetCurrentAdmin().ID;
                }

                return _MyId.Value;
            }
        }

        private Tc.Model.TcAdmin _My;

        /// <summary>
        /// 当前登陆用户信息
        /// </summary>
        protected Tc.Model.TcAdmin My
        {
            get
            {
                if (_My == null)
                    _My = LibAdmin.GetCurrentAdmin();
                return _My;
            }
        }

        #endregion 当前登陆的管理员

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            int id = MyId;
        }

        /// <summary>
        ///  弹出对话框
        /// </summary>
        /// <param name="message">提示信息</param>
        /// <param name="tourl">对话框关闭后的，页面跳转地址</param>
        protected void Alert(string message)
        {
            Alert(message, "");
        }

        /// <summary>
        ///  弹出对话框
        /// </summary>
        /// <param name="message">提示信息</param>
        /// <param name="tourl">对话框关闭后的，页面跳转地址</param>
        protected void Alert(string message, string tourl)
        {
            string s = "alert('" + message + "');";
            if (tourl.Length > 0)
            {
                s += "location='" + tourl + "';";
            }
            ClientScript.RegisterClientScriptBlock(GetType(), "ssssssad", s, true);
        }
    }
}