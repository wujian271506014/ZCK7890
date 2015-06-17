<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="info.aspx.cs" Inherits="Tc.Web.Admin.links.info" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>友情链接管理</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css">
    <script src="../js/jquery-1.4.1.min.js"></script>
    <script src="../js/uploadfy/jquery.uploadify.min.js"></script>
    <link href="../js/uploadfy/uploadify.css" rel="stylesheet" />
</head>
<body background='../images/allbg.gif' leftmargin='8' topmargin='8'>
    <form id="form1" runat="server">
        <table width="98%" border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="#D6D6D6">
            <tr>
                <td height="28" background="../images/tbg.gif" style="padding-left: 10px;"><b><a href="friendlink_main.php"><u>友情链接管理</u></a></b>&gt;&gt;增加链接</td>
            </tr>
            <tr>
                <td height="200" bgcolor="#FFFFFF" valign="top">
                    <input type="hidden" name="dopost" value="add" />
                    <table width="80%" border="0" cellspacing="1" cellpadding="3">
                        <tr>
                            <td width="150px" height="25">网站名称：</td>
                            <td>
                                <asp:TextBox ID="txt_name" runat="server" CssClass="pubinputs"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" 必填" ControlToValidate="txt_name"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td height="25">网址：</td>
                            <td>
                                <asp:TextBox ID="txt_url" runat="server" CssClass="pubinputs"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" 必填" ControlToValidate="txt_url"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td height="25">排列位置：</td>
                            <td>
                                <asp:TextBox ID="txt_paixu" runat="server" CssClass="pubinputs" Text="0" MaxLength="10" Style='width: 60px'></asp:TextBox>
                                (由小到大排列)
                            </td>
                        </tr>
                        <tr>
                            <td height="25">上传Logo：</td>
                            <td>
                                <input type="file" name="uploadify" id="uploadify" />(88*31 gif或jpg)<span id="fileQueue"></span>
                                <br />
                                <img id="img_logo" src="<%=tupianurl %>" style="<%=dp%>" />
                                <input type="hidden" runat="server" id="hd_tupian" />
                            </td>
                        </tr>
                        <tr>
                            <td height="25">是否显示：</td>
                            <td>
                                <asp:RadioButtonList ID="rb_xianshi" runat="server" RepeatColumns="2">
                                    <asp:ListItem Value="1" Text="显示" Selected="True"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="不显示"></asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td height="51">&nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="保 存" OnClick="btn_Add_Click" CssClass="coolbg np" />
                                <input type="reset" name="Submit" value=" 重 置 " class="coolbg np" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
    <script type="text/javascript">

        $(document).ready(function () {
            alert(11);
            $("#uploadify").uploadify({
                swf: '../js/uploadfy/uploadify.swf?' + (new Date()).getTime(),
                uploader: '../handler/tupian.aspx?wh=<%=LibCache.get_theme_config("links_tp_wh")%>',
                queueID: 'fileQueue',
                auto: true,
                multi: false,
                buttonText: '上传图片',
                removeTimeout: 1,
                fileTypeExts: "*.jpg;*.gif;*.png;*.jpeg",
                onUploadSuccess: function (file, data, response) {
                    var rs = eval("(" + data + ")");
                    if (rs.res == "1") {
                        $("#img_logo").show().attr("src", rs.viewname);
                        $("#<%=hd_tupian.ClientID%>").val(rs.rukuname);
                    }
                    else {
                        alert("上传失败");
                    }
                }
            });
        });
    </script>
</body>
</html>