<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="Tc.Web.Admin.liuyan.list" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>留言列表</title>
    <link href="../css/base.css" rel="stylesheet" type='text/css'>
    <script src="../js/jquery-1.4.1.min.js"></script>
    <script src="../js/adminlistdels.js"></script>
    <script src="../../js/artDialog4.1.7/artDialog.js?skin=default"></script>
    <script src="../../js/artDialog4.1.7/plugins/iframeTools.js"></script>
</head>
<body background='../images/allbg.gif' leftmargin='8' topmargin='8'>

    <form id="form1" runat="server">

        <table width="98%" border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="#D6D6D6">
            <tr>
                <td height="28" background="../images/tbg.gif" colspan="8" style="padding-left: 10px;">
                    <div style="float: left">
                        <b>留言列表</b>
                    </div>
                    <div style="float: right; padding-right: 6px;">
                    </div>
                </td>
            </tr>
            <input type='hidden' name='dopost' value='delall' />
            <input type='hidden' name='allid' value='' />
            <tr align="center" bgcolor="#FBFCE2" height="26">
                <td width="6%">选择</td>
                <td width="15%">姓名</td>
                <td width="15%">公司</td>
                <td width="15%">邮箱</td>
                <td width="15%">电话</td>
                <td width="15%">qq</td>
                <td width="15%">管理</td>
            </tr>
            <asp:Repeater ID="rp_list" runat="server">
                <ItemTemplate>
                    <tr align="center" bgcolor="#FFFFFF" height="26" onmousemove="javascript:this.bgColor='#FCFDEE';"
                        onmouseout="javascript:this.bgColor='#FFFFFF';">
                        <td>
                            <input type='checkbox' name='aids' value='<%#Eval("id") %>' class='np'></td>
                        <td><%#Eval("xingming") %></td>
                        <td><%#Eval("gongsimc") %></td>
                        <td><%#Eval("email") %></td>
                        <td><%#Eval("dianhua") %></td>
                        <td><%#Eval("qq") %></td>
                        <td>
                            <input type="hidden" value="<%#Eval("neirong") %>" id='hd_<%#Eval("id") %>' />
                            <a href='javascript:show(<%#Eval("id") %>)'>[查看]</a>
                            <asp:LinkButton ID="lbtnDel" runat="server" OnClientClick="return confirm('确认删除？')"
                                CommandArgument='<%#Eval("ID") %>' OnClick="lbtnDel_Click">[删除]</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr bgcolor="#ffffff" height="28">
                <td colspan="8">
                    <a href='#' onclick='quanxuan()' class='np coolbg'>[全选]</a>
                    <a href='#' onclick='fanxuan()' class='np coolbg'>[取消]</a>
                    <asp:LinkButton ID="lbtnDelete" runat="server" OnClientClick="return confirm('确认删除？')"
                        OnClick="btnDelete_Click">[批量删除]</asp:LinkButton>
                </td>
            </tr>
            <tr align="center" bgcolor="#F9FCEF" height="28">
                <td colspan="8">
                    <webdiyer:AspNetPager ID="aspnetpage" runat="server" FirstPageText="首页" LastPageText="尾页"
                        NextPageText="下一页" PrevPageText="上一页" OnPageChanged="aspnetpage_PageChanged"
                        HorizontalAlign="Center" PageIndexBoxType="DropDownList" ShowPageIndexBox="Always"
                        SubmitButtonText="Go" TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到" PageSize="10" LayoutType="Div">
                    </webdiyer:AspNetPager>
                </td>
            </tr>
        </table>
    </form>
    <script type="text/javascript">
        function show(id) {
            art.dialog({
                content: $("#hd_" + id).val()
            });
        }
    </script>
</body>
</html>
