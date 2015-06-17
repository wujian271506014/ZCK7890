<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Tc.Web.Admin.main" %>

<!--This is IE DTD patch , Don't delete this line.-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title>管理后台-<%=Lib.SysTitle %></title>
    <link href="css/frame.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.4.1.min.js"></script>
    <script src="js/frame.js" language="javascript" type="text/javascript"></script>
    <link href="images/style2/style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #skinlist {
            display: block;
            height: 11px;
            margin-top: 10px;
            overflow: hidden;
            width: 86px;
        }

        #skin div {
            float: left;
        }

        #skin li {
            cursor: pointer;
            float: left;
            height: 11px;
            width: 14px;
        }

        #def div, #s1 div, #s2 div, #s3 div, #s4 div {
            background-image: url("images/skinbutton.png");
            background-repeat: no-repeat;
        }

        #s1 div {
            background-position: 0 0px;
        }

        #s2 div {
            background-position: 0 -11px;
        }

        #s3 div {
            background-position: 0 -22px;
        }

        #s4 div {
            background-position: 0 -33px;
        }

        #s1 div.sel {
            background: url("images/skinbutton.png") no-repeat scroll -14px top transparent;
        }

        #s2 div.sel {
            background: url("images/skinbutton.png") no-repeat scroll -14px -11px transparent;
        }

        #s3 div.sel {
            background: url("images/skinbutton.png") no-repeat scroll -14px -22px transparent;
        }

        #s4 div.sel {
            background: url("images/skinbutton.png") no-repeat scroll -14px -33px transparent;
        }
    </style>
</head>
<body class="showmenu">
    <div class="pagemask"></div>
    <iframe class="iframemask"></iframe>
    <div class="head">
        <div class="top">
            <div class="top_logo">
            </div>
            <div class="top_link">
                <ul>
                    <li class="welcome">您好：admin </li>
                    <li><a href="logout.aspx" target="_top">注销</a></li>
                </ul>
            </div>
        </div>
        <div class="topnav">
            <div class="menuact">
                <a href="#" id="togglemenu">隐藏菜单</a>
            </div>
            <div class="nav" id="nav"></div>
            <div class="sysmsg">
            </div>
        </div>
    </div>
    <div class="left">
        <div class="menu" id="menu">
            <iframe src="menu.aspx" id="menufra" name="menu" frameborder="0"></iframe>
        </div>
    </div>
    <div class="right">
        <div class="main">
            <iframe id="main" name="main" frameborder="0" src="index.aspx"></iframe>
        </div>
        <!--<div id="help"><span id="content"><a href="#">栏目管理操作使用说明</a></span></div>-->
    </div>
    <script language="javascript">
        function JumpFrame(url1, url2) {
            jQuery('#menufra').get(0).src = url1;
            jQuery('#main').get(0).src = url2;
        }
    </script>
</body>
</html>