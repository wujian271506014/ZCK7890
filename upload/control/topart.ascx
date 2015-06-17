<%@ Control Language="C#" AutoEventWireup="true" %>
<div class="Sbox">
    <div class="topic">最新资讯&nbsp;&nbsp;&nbsp;New</div>
    <div class="list">
        <dl>
            <% var prolist = PB.get_article(10, "types='a'", "id desc");
               foreach (var item in prolist)
               {%>
            <dd>· <a href='/news/info.aspx?id=<%=item.ID %>' title='<%=item.Title %>'><%=item.Title.Subs(15) %></a></dd>
            <%} %>
        </dl>
    </div>

</div>
<div class="HeightTab clearfix"></div>