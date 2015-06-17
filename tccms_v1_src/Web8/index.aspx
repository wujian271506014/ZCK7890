<%@ Page Language="C#" AutoEventWireup="true" Inherits="Tc.UI.Index" %>

<%@ Register Src="~/control/bot.ascx" TagPrefix="uc1" TagName="bot" %>
<%@ Register Src="~/control/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/control/nav.ascx" TagPrefix="uc1" TagName="nav" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="X-UA-Compatible" content="IE=7">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title><%=PB.Get("webname") %></title>
    <link href="<%=Lib.theme %>images/style.css" rel="stylesheet" type="text/css" />
    <link href="<%=Lib.theme %>images/common.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="<%=Lib.theme %>js/jquery.min.js"></script>
    <script type="text/javascript" src="<%=Lib.theme %>js/functions.js"></script>
    <script type="text/javascript" src="<%=Lib.theme %>js/focusslide.js"></script>
    <script type="text/javascript" src="<%=Lib.theme %>images/iepng/iepngfix_tilebg.js"></script>
</head>

<body>
    <div id="wrapper">

        <!--head start-->
        <div id="head">
            <uc1:top runat="server" ID="top" />
            <uc1:nav runat="server" ID="nav" />
            <!--focus start-->
            <div id="FocusBG">
                <div id="Focus">
                    <ul>
                        <% var hdp = PB.get_huandong("index");
                           foreach (var item in hdp)
                           {%>
                        <li><a href='<%=item.Url %>' target='_blank'>
                            <img src='<%=LibFile.get_img(item.Tupian,"","") %>' alt='<%=item.Title %>' /></a></li>
                        <%}  %>
                    </ul>
                </div>
            </div>
            <!--foncus end-->
            <div class="HeightTab clearfix"></div>
        </div>
        <!--head end-->
        <!--body start-->
        <div id="body">
            <!--MainBlock start-->
            <div class="MainBlock">
                <!--left start-->
                <div class="right">
                    <div class="topic">
                        <div class="TopicTitle"><a href="/page/company.aspx">关于公司</a></div>
                        <div class="TopicMore">
                            <a href='/page/company.aspx'>
                                <img src="<%=Lib.theme %>images/more.png"></a>
                        </div>
                    </div>
                    <div class='img'>
                        <% var _cm = PB.get_danye_model("company"); %>
                        <img src='<%=LibFile.get_img(_cm.Tupian,"250","100") %>' width='250' height='100' alt='关于公司'>
                    </div>
                    <div class='txt ColorLink'>
                        <p>
                            <%=_cm.Content.DeleteHMTL().Subs(90) %><a href='/page/company.aspx' target='_blank'>详细>></a>
                        </p>
                    </div>
                    <div class=" clearfix"></div>
                </div>
                <!--left end-->
                <div class='WidthTab2'></div>

                <!--right start-->
                <div class="left">
                    <div class="tab">
                        <ul class="tab-hd">
                            <li><a href='/news/list.aspx?c=13'>公司新闻</a></li>
                            <li><a href='/news/list.aspx?c=14'>行业新闻</a></li>
                        </ul>
                        <ul class="tab-bd">
                            <li>
                                <div class='DivList'>
                                    <% var newslist = PB.get_article(9, "types='a' and Fenleiid=13", "id desc");
                                       foreach (var item in newslist)
                                       {%>
                                    <div class='DivLi'><span><%=item.Addtime.GetDateTime().ToString("yyyy-MM-dd") %></span> <a href='/news/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title %>'><%=item.Title.Subs(16) %></a></div>
                                    <%} %>
                                    <div class='clearfix'></div>
                                </div>
                            </li>
                            <li>
                                <div class='DivList'>
                                    <% var newslist2 = PB.get_article(9, "types='a' and Fenleiid=14", "id desc");
                                       foreach (var item in newslist2)
                                       {%>
                                    <div class='DivLi'><span><%=item.Addtime.GetDateTime().ToString("yyyy-MM-dd") %></span> <a href='/news/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title %>'><%=item.Title.Subs(16) %></a></div>
                                    <%} %>
                                    <div class='clearfix'></div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <!--right end-->

                <!--right2 start-->
                <div class="right2">
                    <div class="tab">
                        <ul class="tab-hd">
                            <li><a href='/Product/list.aspx'>推荐产品</a></li>
                        </ul>
                        <ul class="tab-bd">
                            <li>
                                <div class='DivList'>

                                    <% var prolist2 = PB.get_article(9, "types='c'", "id desc");
                                       foreach (var item in prolist2)
                                       {%>
                                    <div class='DivLi'>· <a href='/product/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title %>'><%=item.Title.Subs(18) %></a></div>
                                    <%} %>
                                    <div class='clearfix'></div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <!--right2 end-->
                <div class="clearfix"></div>
            </div>
            <!--MainBlock end-->

            <div class="HeightTab clearfix"></div>
            <!--MainBlock2 start-->
            <div class="MainBlock">
                <!--left start-->
                <div class="right">
                    <div class="topic">
                        <div class="TopicTitle"><a href='/anli/list.aspx'>案例展示</a></div>
                        <div class="TopicMore">
                            <a href='/anli/list.aspx'>
                                <img src="<%=Lib.theme %>images/more.png"></a>
                        </div>
                    </div>
                    <div class="HeightTab clearfix"></div>

                    <div class="PicBlock">

                        <% var anli = PB.get_article(7, "types='al'", "id desc");
                           foreach (var item in anli)
                           {%>
                        <div class='CasePicBlock'>
                            <div class='BlockPic'>
                                <a href='/anli/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title %>'>
                                    <img alt='<%=item.Title %>' src='<%=LibFile.get_img(item.Tupian,"156","116") %>'></a>
                            </div>
                            <div class='BlockTitle'><a href='/anli/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title %>'><%=item.Title.Subs(10) %></a></div>
                        </div>
                        <%}  %>
                        <div class=" clearfix"></div>
                    </div>

                    <div class=" clearfix"></div>
                </div>
                <!--left end-->
                <div class='WidthTab2'></div>

                <!--right start-->
                <div class="left">
                    <div class="tab">
                        <ul class="tab-hd">
                            <li><a href='/news/list.aspx?c=18'>技术支持</a></li>
                        </ul>
                        <ul class="tab-bd">
                            <li>
                                <div class='DivList'>
                                    <% var newslist3 = PB.get_article(9, "types='a' and Fenleiid=18", "id desc");
                                       foreach (var item in newslist3)
                                       {%>
                                    <div class='DivLi'><span><%=item.Addtime.GetDateTime().ToString("yyyy-MM-dd") %></span> <a href='/news/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title %>'><%=item.Title.Subs(16) %></a></div>
                                    <%} %>
                                    <div class='clearfix'></div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <!--right end-->

                <!--right2 start-->
                <div class="right2">
                    <div class="topic">
                        <div class="TopicTitle"><a href='/page/contact.aspx'>联系方式</a></div>
                        <div class="TopicMore">
                            <a href='/page/contact.aspx'>
                                <img src="<%=Lib.theme %>images/more.png"></a>
                        </div>
                    </div>
                    <div class='img'>
                        <a href='/page/contact.aspx' target='_blank'>
                            <img src='<%=Lib.theme %>images/join.jpg' width='233' height='100' alt='联系方式'></a>
                    </div>
                    <div class="txt ColorLink">
                        <p>地址：<%=PB.Get("dizhi") %></p>
                        <p>电话：<%=PB.Get("dianhua") %></p>
                        <p>传真：<%=PB.Get("chuanzhen") %></p>
                        <p>邮件：<%=PB.Get("email") %></p>
                        <p>网址：<a href='<%=PB.Get("web") %>' target='_blank'><%=PB.Get("web") %></a></p>
                        <p align='center'>
                            <a href="http://wpa.qq.com/msgrd?v=3&uin=<%=PB.Get("qq1") %>&site=qq&menu=yes" target="_blank">
                                <img src="<%=Lib.theme %>images/qqimg/webqq.gif" alt='在线QQ交谈' /></a> &nbsp;&nbsp;<a href="http://wpa.qq.com/msgrd?v=3&uin=<%=PB.Get("qq2") %>&site=qq&menu=yes" target="_blank"><img src="<%=Lib.theme %>images/qqimg/webqq.gif" alt='在线QQ交谈' /></a>
                        </p>
                    </div>

                    <div class=" clearfix"></div>
                </div>
                <!--right2 end-->
                <div class="clearfix"></div>
            </div>
            <!--MainBlock2 end-->

            <div class="HeightTab clearfix"></div>

            <!--ProductShow start-->
            <div class="ProductShow">
                <div class="topic">
                    <div class="TopicTitle">公司产品</div>
                    <div class="TopicMore">
                        <a href='/product/list.aspx'>
                            <img src="<%=Lib.theme %>images/more.png"></a>
                    </div>
                </div>
                <div class="hjnavC">
                    <div class="hjnavcn">
                        <div class='hjone'>
                            <% var prolist = PB.get_article(5, "types='c'", "id desc");
                               foreach (var item in prolist)
                               {%>
                            <div class='albumblock'>
                                <div class='inner'>
                                    <a href='/product/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title %>'>
                                        <img src='<%=LibFile.get_img(item.Tupian.GetString(),"270","270") %>' alt='<%=item.Title %>' /></a><div class='albumtitle'><a href='/product/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title.Subs(10) %>'><%=item.Title.Subs(10) %></a></div>
                                </div>
                            </div>
                            <%} %>
                        </div>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
            <script type="text/javascript" src="<%=Lib.theme %>js/h.js"></script>
            <!--ProductShow end-->
            <div class="HeightTab clearfix"></div>
            <!--links start-->
            <div id="Links">
                <span>友情链接：</span>
                <% var linklist = PB.get_links(100, "");
                   foreach (var item in linklist)
                   {
                %>
                <a href='<%=item.Url %>' target='_blank'><%=item.Name %></a>
                <%
                   }
                %>
            </div>
            <!--links end-->
        </div>
        <!--body end-->

        <uc1:bot runat="server" ID="bot" />
    </div>
</body>
</html>