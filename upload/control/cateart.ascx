<%@ Control Language="C#" AutoEventWireup="true" %>
<div class="Sbox">
    <div class="topic">新闻动态&nbsp;&nbsp;&nbsp;News</div>
    <div class="blank">
        <ul>
            <% var t_ncate = LibCache.get_fenleis("a");
               foreach (var item in t_ncate)
               {
            %>
            <li><a href='/news/list.aspx?c=<%=item.ID %>'><%=item.Name %></a></li>
            <%  } %>
        </ul>
    </div>
</div>
<div class="HeightTab clearfix"></div>
