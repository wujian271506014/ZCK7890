<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Tc.Web.Admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title><%=Lib.SysTitle %></title>
    <link href="../images/admin/css/base.css" rel="stylesheet" />
    <link href="../images/admin/css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="login-box">
            <div class="login-top"></div>
            <div class="login-main">
                <input type="hidden" name="gotopage" value="/dede/" />
                <input type="hidden" name="dopost" value="login" />
                <input name='adminstyle' type='hidden' value='newdedecms' />
                <dl>
                    <dt>用户名：</dt>
                    <dd>
                        <asp:TextBox ID="txt_name" MaxLength="20" runat="server"></asp:TextBox></dd>
                    <dt>密&nbsp;&nbsp;码：</dt>
                    <dd>
                        <asp:TextBox ID="txt_pwd" MaxLength="20" TextMode="Password" runat="server"
                            Style="ime-mode: disabled;"></asp:TextBox></dd>
                    <dt>&nbsp;</dt>
                    <dd>
                        <asp:Button ID="Button1" runat="server" Text="登陆" CssClass="login-btn" OnClick="Button1_Click" /></dd>
                </dl>
            </div>
            <div class="login-power">Powered by<a href="http://www.tuichu.net"><strong>推出网官网</strong></a>&copy; 2012-2013<a href="http://www.tuichu.net" target="_blank">Tuichu</a> Inc.</div>
        </div>
    </form>
    <script>
        window.onload = function () {
            if (window.location != window.parent.location) {
                window.parent.location = window.location;
            }
        }
    </script>
</body>
</html>