<%@ Control Language="C#" AutoEventWireup="true" %>
<div class="Sbox">
    <div class="topic">联系我们&nbsp;&nbsp;&nbsp;Contact</div>
    <div class="txt ColorLink">
        <p>地址：<%=PB.Get("dizhi") %></p>
        <p>电话：<%=PB.Get("dianhua") %></p>
        <p>传真：<%=PB.Get("chuanzhen") %></p>
        <p>邮件：<%=PB.Get("email") %></p>
        <p>网站：<a href='<%=PB.Get("web") %>' target='_blank'><%=PB.Get("web") %></a> </p>
        <p align='center'>
            <a href="http://wpa.qq.com/msgrd?v=3&uin=<%=PB.Get("qq1") %>&site=qq&menu=yes" target="_blank">
                                <img src="<%=Lib.theme %>images/qqimg/webqq.gif" alt='在线QQ交谈' /></a> &nbsp;&nbsp;<a href="http://wpa.qq.com/msgrd?v=3&uin=<%=PB.Get("qq2") %>&site=qq&menu=yes" target="_blank"><img src="<%=Lib.theme %>images/qqimg/webqq.gif" alt='在线QQ交谈' /></a>
        </p>
    </div>
</div>

<div class="HeightTab clearfix"></div>
