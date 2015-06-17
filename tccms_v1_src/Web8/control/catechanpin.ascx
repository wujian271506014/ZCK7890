<%@ Control Language="C#" AutoEventWireup="true" %>
<div class="Sbox">
    <div class="topic">公司产品&nbsp;&nbsp;&nbsp;About</div>
    <div class="blank">
        <ul>
            <% var t_pcate = LibCache.get_fenleis("c");
               foreach (var item in t_pcate)
               {
            %>
            <li><a href='/product/list.aspx?c=<%=item.ID %>'><%=item.Name %></a></li>
            <%  } %>
        </ul>
    </div>
</div>
<div class="HeightTab clearfix"></div>