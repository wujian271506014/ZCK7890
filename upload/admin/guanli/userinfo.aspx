<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userinfo.aspx.cs" Inherits="Tc.Web.Admin.guanli.userinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>管理员信息</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.4.1.min.js"></script>
    <script src="../js/uploadfy/jquery.uploadify.min.js"></script>
    <link href="../js/uploadfy/uploadify.css" rel="stylesheet" />
</head>
<body topmargin="8">
    <form id="form1" runat="server">
        <table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td width="60%" height="30">
                    <img height="14" src="../images/book1.gif" width="20">&nbsp;&gt;&gt; 管理员信息</td>
                <td width="30%" align='right'>&nbsp; </td>
            </tr>
        </table>

        <table width="98%" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#FBFCE2" id="getone" style="display: none">
        </table>
        <table width="98%" border="0" align="center" cellpadding="2" cellspacing="2" id="needset" style="border: 1px solid #cfcfcf; background: #ffffff;">
            <tr>
                <td height="24" colspan="5" class="bline">
                    <table width="800" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="90">&nbsp;登录名：</td>
                            <td>
                                <asp:TextBox ID="txt_title" runat="server" Style="width: 388px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" 必填" ControlToValidate="txt_title"></asp:RequiredFieldValidator></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="24" colspan="5" class="bline">
                    <table width="800" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="90">&nbsp;密码：</td>
                            <td>
                                <asp:TextBox ID="txt_pwd" runat="server" TextMode="Password" Style="width: 388px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage=" 必填" ControlToValidate="txt_pwd"></asp:RequiredFieldValidator></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="24" colspan="5" class="bline">
                    <table width="800" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="90">&nbsp;确认密码：</td>
                            <td>
                                <asp:TextBox ID="txt_pwd2" runat="server" TextMode="Password" Style="width: 388px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table width="98%" border="0" cellspacing="0" cellpadding="0" align="center" bgcolor="#F9FCEF" style="border: 1px solid #cfcfcf; border-top: none;">
            <tr height="35">
                <td width="17%">&nbsp;</td>
                <td width="83%">
                    <asp:ImageButton ID="ImageButton1" ImageUrl="~/Admin/images/button_save.gif" runat="server" OnClick="ImageButton1_Click" />
                    <img src="../images/button_reset.gif" width="60" height="22" border="0" onclick="location.reload();" style="cursor: pointer;" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>