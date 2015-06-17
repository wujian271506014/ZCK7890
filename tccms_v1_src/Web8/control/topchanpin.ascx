<%@ Control Language="C#" AutoEventWireup="true" %>
<div class="Sbox">
    <div class="topic">热门产品&nbsp;&nbsp;&nbsp;Hot</div>
    <div class="list">
        <dl>
            <% var prolist = PB.get_article(10, "types='c'", "id desc");
               foreach (var item in prolist)
               {%>
            <dd>· <a href='/product/info.aspx?id=<%=item.ID %>' title='<%=item.Title %>'><%=item.Title.Subs(16) %></a></dd>
            <%} %>
        </dl>
    </div>

</div>
<div class="HeightTab clearfix"></div>
