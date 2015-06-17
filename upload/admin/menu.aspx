<%@ Page Language="C#" AutoEventWireup="true" Inherits="Tc.UI.Admin.Menu" %>

<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title>菜单</title>
    <link rel="stylesheet" href="css/base.css" type="text/css" />
    <script src="js/jquery.js" language="javascript" type="text/javascript"></script>
    <script language='javascript'>var curopenItem = '1';</script>
    <script language="javascript" type="text/javascript" src="js/leftmenu.js"></script>
    <link href="css/menu.css" rel="stylesheet" />
    <link href="images/style2/style.css" rel="stylesheet" type="text/css" />
    <base target="main" />
</head>
<body target="main" onload="CheckOpenMenu();">
    <table width="180" align="left" border='0' cellspacing='0' cellpadding='0' style="text-align: left;">
        <tr>
            <td valign='top' style='padding-top: 10px' width='20'><a id='link1' class='mmac'>
                <div onclick="ShowMainMenu(1)">核心</div>
            </a>
            </td>
            <td width='160' id='mainct' valign="top">
                <div id='ct1'>
                    <!-- Item 2 Strat -->
                    <dl class='bitem' id='sunitems1_1'>
                        <dt onclick='showHide("items1_1")'><b>常用操作</b></dt>
                        <dd style='display: block' class='sitem' id='items1_1'>
                            <ul class='sitemu'>
                                <li>
                                    <div class='items'>
                                        <div class='fllct'><a href='article/info.aspx?types=a' target='main'>发布文章</a></div>

                                        <div class='flrct'>
                                            <a href='article/info.aspx?types=a' target='main'>
                                                <img src='images/gtk-sadd.png' alt='录入新文章' title='录入文章' /></a>
                                        </div>
                                    </div>
                                </li>
                                <li><a href='article/list.aspx?types=a' target='main'>文章列表</a></li>
                                <li><a href='zidian/fenlei.aspx?types=a' target='main'>文章分类管理</a></li>
                                <li>
                                    <div class='items'>
                                        <div class='fllct'><a href='chanpin/info.aspx?types=c' target='main'>发布产品</a></div>

                                        <div class='flrct'>
                                            <a href='chanpin/info.aspx?types=c' target='main'>
                                                <img src='images/gtk-sadd.png' alt='发布产品' title='发布产品' /></a>
                                        </div>
                                    </div>
                                </li>
                                <li><a href='chanpin/list.aspx?types=c' target='main'>产品列表</a></li>
                                <li><a href='zidian/fenlei.aspx?types=c' target='main'>产品分类管理</a></li>
                                <li><a href='danye/info.aspx' target='main'>新增单页</a></li>
                                <li><a href='danye/list.aspx' target='main'>单页管理</a></li>
                                <li><a href='zidian/list.aspx?types=danye' target='main'>单页分类管理</a></li>
                                <li><a href='article/list.aspx?types=al' target='main'>应用案例管理</a></li>
                            </ul>
                        </dd>
                    </dl>
                    <!-- Item 2 End -->
                    <!-- Item 5 Strat -->
                    <dl class='bitem' id='sunitems4_1'>
                        <dt onclick='showHide("items4_1")'><b>其他管理</b></dt>
                        <dd style='display: block' class='sitem' id='items4_1'>
                            <ul class='sitemu'>
                                <li><a href='liuyan/list.aspx' target='main'>留言管理</a></li>
                                <li><a href='ad/list.aspx' target='main'>广告管理</a></li>
                                <li><a href='huandeng/list.aspx?types=index&width=980&height=300' target='main'>幻灯片管理</a></li>
                                <li><a href='links/list.aspx' target='main'>友情链接管理</a></li>
                            </ul>
                        </dd>
                    </dl>
                    <dl class='bitem' id='sunitems5_1'>
                        <dt onclick='showHide("items5_1")'><b>网站管理</b></dt>
                        <dd style='display: block' class='sitem' id='items5_1'>
                            <ul class='sitemu'>
                                <li><a href='config/list.aspx?types=web' target='main'>网站配置</a></li>
                                <li><a href='zidian/list.aspx' target='main'>字典管理</a></li>
                                <li><a href='guanli/pwd.aspx' target='main'>修改登陆密码</a></li>
                            </ul>
                        </dd>
                    </dl>
                    <!-- Item 5 End -->
                </div>
                <div id='ct100'></div>
                <div id='ct3'></div>
                <div id='ct5'></div>
                <div id='ct6'></div>
                <div id='ct7'></div>
                <div id='ct20'></div>
                <div id='ct10'></div>
            </td>
        </tr>
        <tr>
            <td width='26'></td>
            <td width='160' valign='top'>
                <img src='images/idnbgfoot.gif' /></td>
        </tr>
    </table>
    <script language="javascript">
        function myAlert() {
            alert('dede');
        }
    </script>
</body>
</html>