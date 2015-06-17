<%@ Control Language="C#" AutoEventWireup="true" %>
<div class="HeightTab clearfix"></div>
<!--footer start-->
<div id="footer">
    <div class="inner">
        <div class='BottomNav'><a href="/">网站首页</a> | <a href="/page/company.aspx">关于我们</a> | <a href="/page/job.aspx">人才招聘</a>  | <a href="/page/contact.aspx">联系我们</a></div>
        <div class='HeightTab'></div>
        <p>公司地址：<%=PB.Get("dizhi") %> 联系电话：<%=PB.Get("dianhua") %> 电子邮件：<%=PB.Get("email") %></p>
        <p>Copyright 2013  <%=PB.Get("webname") %> 版权所有 All rights reserved</p>
    </div>
</div>
<!--footer end -->
<script src="/js/lrkf/js/lrkf.js"></script>
<link href="/js/lrkf/skin/lrkf_blue1.css" rel="stylesheet" />
<script type="text/javascript">
    $(function () {
        $("#lrkfwarp").lrkf({
            kftop: '140',
            Event: 'hover',
            qqs: [
                { 'name': '客服1号', 'qq': '<%=PB.Get("qq1")%>' },
                { 'name': '客服2号', 'qq': '<%=PB.Get("qq2")%>' }
            ],
            tel: [
                { 'name': '电话', 'tel': '<%=PB.Get("dianhua")%>' }
            ],
        });
    });
</script>