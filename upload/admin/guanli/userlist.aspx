<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userlist.aspx.cs" Inherits="Tc.Web.Admin.guanli.userlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>管理员列表</title>
    <link href="../css/base.css" rel="stylesheet" type='text/css'>
    <script src="../js/jquery-1.4.1.min.js"></script>
    <script src="../js/adminlistdels.js"></script>
</head>
<body background='../images/allbg.gif' leftmargin='8' topmargin='8'>

    <form id="form1" runat="server">

        <table width="98%" border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="#D6D6D6">
            <tr>
                <td height="28" background="../images/tbg.gif" colspan="8" style="padding-left: 10px;">
                    <div style="float: left">
                        <b>管理员列表</b>
                    </div>
                    <div style="float: right; padding-right: 6px;">
                        [<a href="userinfo.aspx"><u>新增管理员</u></a>]
                    </div>
                </td>
            </tr>
            <input type='hidden' name='dopost' value='delall' />
            <input type='hidden' name='allid' value='' />
            <tr align="center" bgcolor="#FBFCE2" height="26">
                <td width="6%">选择</td>
                <td width="40%">管理员名称</td>
                <td width="20%">级别（一级不可删除）</td>
                <td width="15%">管理</td>
            </tr>
            <asp:Repeater ID="rp_list" runat="server">
                <ItemTemplate>
                    <tr align="center" bgcolor="#FFFFFF" height="26" onmousemove="javascript:this.bgColor='#FCFDEE';"
                        onmouseout="javascript:this.bgColor='#FFFFFF';">
                        <td>
                            <input type='checkbox' name='aids' value='<%#Eval("id") %>' class='np'></td>
                        <td><%#Eval("Name") %></td>
                        <td><%#Eval("role") %></td>
                        <td>
                            <a href='userinfo.aspx?id=<%#Eval("id") %>'>[更改]</a>
                            <asp:LinkButton ID="lbtnDel" runat="server" OnClientClick="return confirm('确认删除？')"
                                CommandArgument='<%#Eval("ID") %>' OnClick="lbtnDel_Click">[删除]</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr align="center" bgcolor="#F9FCEF" height="28">
                <td colspan="8"></td>
            </tr>
        </table>
    </form>
</body>
</html>