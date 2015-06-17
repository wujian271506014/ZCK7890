<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" ValidateRequest="false" Inherits="Tc.Web.Admin.config.list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>网站配置管理</title>
    <link href="../css/base.css" rel="stylesheet" type='text/css'>
</head>
<body background='../images/allbg.gif' leftmargin='8' topmargin='8'>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <table width="99.9%" border="0" cellpadding="2" cellspacing="0" bgcolor="#D1DDAA"
                align="center" style="margin-top: 8px">
                <tr bgcolor="#E7E7E7">
                    <td height="24" background="../img/tbg.gif" style="text-align: left">◆ 网站配置管理 &gt;
                    <asp:Label ID="lblTitle" runat="server"></asp:Label>
                        &nbsp;
                    </td>
                    <td background="../img/tbg.gif" style="text-align: right; color: Red">&nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="gvqy" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                Style="margin: auto;" OnRowCancelingEdit="gvqy_RowCancelingEdit" OnRowEditing="gvqy_RowEditing"
                OnRowUpdating="gvqy_RowUpdating"
                Width="99.9%" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="编号" SortExpression="id" ReadOnly="True"
                        Visible="False" />
                    <asp:TemplateField HeaderText="调用参数" SortExpression="sequence" ItemStyle-Width="20%">
                        <ItemTemplate>
                            <asp:Label ID="lblqypx" runat="server" Text='<%# Bind("ename") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtqypx" runat="server" Text='<%# Bind("ename") %>' Width="50px"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtqypx"
                                Display="Dynamic" ErrorMessage="请输入调用参数！" ValidationGroup="paixu">请输入调用参数！</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <HeaderStyle BorderColor="#CBD8AC" CssClass="gvheaderbg" />
                        <ItemStyle BorderColor="#CBD8AC" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="名称" SortExpression="name" ItemStyle-Width="20%">
                        <ItemTemplate>
                            <asp:Label ID="lblqymc" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtqymc" runat="server" Text='<%# Bind("name") %>' Width="200"
                                TextMode="SingleLine"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtqymc"
                                Display="Dynamic" ErrorMessage="请输入名称！" ValidationGroup="paixu">请输入名称！</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <HeaderStyle BorderColor="#CBD8AC" CssClass="gvheaderbg" />
                        <ItemStyle BorderColor="#CBD8AC" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="内容" SortExpression="name" ItemStyle-Width="30%">
                        <ItemTemplate>
                            <asp:Label ID="lblcontent" runat="server" Text='<%# Bind("content") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtcontent" runat="server" Text='<%# Bind("content") %>' Width="200"
                                TextMode="SingleLine"></asp:TextBox>
                        </EditItemTemplate>
                        <HeaderStyle BorderColor="#CBD8AC" CssClass="gvheaderbg" />
                        <ItemStyle BorderColor="#CBD8AC" />
                    </asp:TemplateField>
                    <asp:CommandField HeaderText="编辑" ShowEditButton="True" ValidationGroup="paixu" ItemStyle-Width="15%">
                        <HeaderStyle BorderColor="#CBD8AC" CssClass="gvheaderbg" />
                        <ItemStyle BorderColor="#CBD8AC" />
                    </asp:CommandField>
                    <asp:TemplateField HeaderText="删除" ItemStyle-Width="15%">
                        <ItemTemplate>
                            <asp:LinkButton ID="button1" runat="server" CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm('确定删除吗？')"
                                Text="删除" OnClick="buttondel_Click" ValidationGroup="ppp" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="#CBD8AC" CssClass="gvheaderbg" />
                        <ItemStyle BorderColor="#CBD8AC" />
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#3C86C5" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#3C86C5" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <br />
            <table width='99.9%' border='0' cellpadding='1' cellspacing='1' bgcolor='#CBD8AC'
                align="center" style="margin-top: 8px">
                <tr bgcolor='#EEF4EA'>
                    <td align='center'>
                        <table border='0' cellpadding='0' cellspacing='0'>
                            <tr>
                                <td>名 称：&nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:TextBox ID="txtqymc" runat="server" Width="100" TextMode="SingleLine"></asp:TextBox>
                                </td>
                                <td>&nbsp;&nbsp;调用参数：&nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:TextBox ID="txtpx" runat="server" Width="100px"></asp:TextBox>
                                </td>
                                <td>&nbsp;&nbsp;内容：&nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcontent" runat="server" Width="155px"></asp:TextBox>
                                </td>
                                <td>&nbsp;&nbsp;
                                <asp:Button ID="btnAddQY" runat="server" Text="添  加" CssClass="coolbg np" OnClick="btnAddQY_Click" />
                                </td>
                                <td>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtqymc"
                                    ErrorMessage="请输入名称！" Display="Dynamic">请输入名称！</asp:RequiredFieldValidator>
                                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtpx"
                                        ErrorMessage="请输入调用参数！" Display="Dynamic">请输入调用参数！</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>