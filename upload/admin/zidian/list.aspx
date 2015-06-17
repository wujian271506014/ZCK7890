<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="Tc.Web.Admin.zidian.list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>字典管理</title>
    <link href="../css/base.css" rel="stylesheet" type='text/css'>
</head>
<body background='../images/allbg.gif' leftmargin='8' topmargin='8'>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <table width="99.9%" border="0" cellpadding="2" cellspacing="0" bgcolor="#D1DDAA"
                align="center" style="margin-top: 8px">
                <tr bgcolor="#E7E7E7">
                    <td height="24" background="../img/tbg.gif" style="text-align: left">◆ 字典管理 &gt;
                    <asp:Label ID="lblTitle" runat="server"></asp:Label>
                        &nbsp;
                    </td>
                    <td background="../img/tbg.gif" style="text-align: right; color: Red">排序数字越小越靠前！
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="gvqy" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                Style="margin: auto;" OnRowCancelingEdit="gvqy_RowCancelingEdit" OnRowEditing="gvqy_RowEditing"
                OnRowUpdating="gvqy_RowUpdating"
                Width="99.9%" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="编号" SortExpression="id" ReadOnly="True" />
                    <asp:TemplateField HeaderText="排序" SortExpression="sequence" ItemStyle-Width="20%">
                        <ItemTemplate>
                            <asp:Label ID="lblqypx" runat="server" Text='<%# Bind("paixu") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtqypx" runat="server" Text='<%# Bind("paixu") %>' Width="50px"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtqypx"
                                Display="Dynamic" ErrorMessage="请输入整数！" Operator="DataTypeCheck" Type="Integer"
                                ValidationGroup="paixu">请输入整数！</asp:CompareValidator>
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
                    <asp:CommandField HeaderText="编辑" ShowEditButton="True" ValidationGroup="paixu" ItemStyle-Width="20%">
                        <HeaderStyle BorderColor="#CBD8AC" CssClass="gvheaderbg" />
                        <ItemStyle BorderColor="#CBD8AC" />
                    </asp:CommandField>
                    <asp:TemplateField HeaderText="删除" ItemStyle-Width="20%">
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
                                    <asp:TextBox ID="txtqymc" runat="server" Width="200" TextMode="SingleLine"></asp:TextBox>
                                </td>
                                <td>&nbsp;&nbsp;排序：&nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:TextBox ID="txtpx" runat="server" Width="155px"></asp:TextBox>
                                </td>
                                <td>&nbsp;&nbsp;
                                <asp:Button ID="btnAddQY" runat="server" Text="添  加" CssClass="coolbg np" OnClick="btnAddQY_Click" />
                                </td>
                                <td>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtqymc"
                                    ErrorMessage="请输入内容！" Display="Dynamic">请输入内容！</asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtpx"
                                        Display="Dynamic" ErrorMessage="请输入整数！" Operator="DataTypeCheck" Type="Integer">请输入整数！</asp:CompareValidator>
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