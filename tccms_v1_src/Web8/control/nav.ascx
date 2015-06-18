<%@ Control Language="C#" AutoEventWireup="true" %>
<!--nav start-->
<div id="NavLink">
    <div class="NavBG">
        <!--Head Menu Start-->
        <ul id='sddm'>
            <li class='CurrentLi'><a href='/index.aspx'>网站首页
            </a></li>
            <li><a href='/page/company.aspx' onmouseover="mopen('m2')" onmouseout='mclosetime()'>关于公司
            </a>
                <div id='m2' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'><a href='/page/company.aspx'>公司介绍</a> <a href='/page/zuzhi.aspx'>组织机构</a> <a href='/page/wenhua.aspx'>企业文化</a> <a href='/page/huanjing.aspx'>公司环境</a> <a href='/page/yewu.aspx'>业务介绍</a> </div>
            </li>
            <li><a href='/product/list.aspx' onmouseover="mopen('m3')" onmouseout='mclosetime()'>产品展示
            </a>
                <div id='m3' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'>
                    <% var t_pcate = LibCache.get_fenleis("c");
                       foreach (var item in t_pcate)
                       {
                    %>
                    <a href='/product/list.aspx?c=<%=item.ID %>'><%=item.Name %></a>
                    <%  } %>
                </div>
            </li>
            <li><a href='/news/list.aspx' onmouseover="mopen('m4')" onmouseout='mclosetime()'>新闻资讯
            </a>
                <div id='m4' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'>
                    <% var t_ncate = LibCache.get_fenleis("a");
                       foreach (var item in t_ncate)
                       {
                    %>
                    <a href='/news/list.aspx?c=<%=item.ID %>'><%=item.Name %></a>
                    <%  } %>
                </div>
            </li>
            <li><a href='/anli/list.aspx' onmouseover="mopen('m5')" onmouseout='mclosetime()'>案例展示
            </a>
            </li>
            <li><a href='/page/zhichi.aspx' onmouseover="mopen('m5')" onmouseout='mclosetime()'>技术支持
            </a>
            </li>
            <li><a href='/page/job.aspx' onmouseover="mopen('m6')" onmouseout='mclosetime()'>人才招聘
            </a>
            </li>
            <li><a href='/page/contact.aspx'>联系方式
            </a></li>
            <li><a href='/liuyan.aspx'>在线留言
            </a></li>
        </ul>
        <!--Head Menu End-->
    </div>
    <div class="clearfix"></div>
</div>
<!--nav end-->
