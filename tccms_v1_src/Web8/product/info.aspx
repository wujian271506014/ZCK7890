﻿<%@ Page Language="C#" AutoEventWireup="true" Inherits="Tc.UI.ProductInfo" %>

<%@ Register Src="~/control/bot.ascx" TagPrefix="uc1" TagName="bot" %>
<%@ Register Src="~/control/ad.ascx" TagPrefix="uc1" TagName="ad" %>
<%@ Register Src="~/control/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/control/nav.ascx" TagPrefix="uc1" TagName="nav" %>
<%@ Register Src="~/control/catechanpin.ascx" TagPrefix="uc1" TagName="catechanpin" %>
<%@ Register Src="~/control/contact.ascx" TagPrefix="uc1" TagName="contact" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="X-UA-Compatible" content="IE=7">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title><%=art.Title %>-<%=PB.Get("webname") %></title>
    <link href="<%=Lib.theme %>images/inner.css" rel="stylesheet" type="text/css" />
    <link href="<%=Lib.theme %>images/common.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="<%=Lib.theme %>js/jquery.min.js"></script>
    <script type="text/javascript" src="<%=Lib.theme %>js/functions.js"></script>
    <script type="text/javascript" src="<%=Lib.theme %>images/iepng/iepngfix_tilebg.js"></script>
</head>

<body>
    <div id="wrapper">
        <!--head start-->
        <div id="head">
            <uc1:top runat="server" ID="top" />
            <uc1:nav runat="server" ID="nav" />
        </div>
        <!--head end-->
        <!--body start-->
        <div id="body">
            <!--focus start-->
            <div id="InnerBanner">
            </div>
            <!--foncus end-->
            <div class="HeightTab clearfix"></div>
            <!--inner start -->
            <div class="inner">
                <!--left start-->
                <div class="left">
                    <uc1:catechanpin runat="server" ID="catechanpin" />
                    <uc1:contact runat="server" ID="contact" />
                </div>
                <!--left end-->
                <!--right start-->
                <div class="right">
                    <div class="Position"><span>你的位置：<a href="/">首页</a> > <a href='/product/list.aspx'>公司产品</a></span></div>
                    <div class="HeightTab clearfix"></div>
                    <!--main start-->
                    <div class="main">
                        <!--content start-->
                        <div class="content">
                            <div class="ProInfo">
                                <div class="image">
                                    <a href="javascript:void(0)" title="<%=art.Title %>">
                                        <img src="<%=LibFile.get_img(art.Tupian.GetString(),"270","270") %>" height="270" width="270"></a>
                                </div>
                                <div class="column">
                                    <div class="title">
                                        <h3><%=art.Title %></h3>
                                    </div>
                                    <div class="infos"><%=art.Addtime.GetDateTime().ToString("yyyy-MM-dd") %></div>
                                    <ul>
                                        <li><%=prt.Shuxing.GetString().Replace("\r","</li><li>") %></li>
                                    </ul>
                                </div>
                                <div class="clearfix"></div>
                            </div>

                            <div class="maincontent clearfix">
                                <div class="IntroTitle">产品介绍</div>
                                <%=art.Content %>
                            </div>
                        </div>
                        <!--content end-->
                    </div>
                    <!--main end-->
                </div>
                <!--right end-->
            </div>
            <!--inner end-->
        </div>
        <!--body end-->

        <uc1:bot runat="server" ID="bot" />
    </div>
</body>
</html>