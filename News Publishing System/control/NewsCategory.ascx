<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsCategory.ascx.cs" Inherits="News_Publishing_System.control.NewsCategory" %>

        <!--新闻分类-->
        <div id="category" class="commonfrm">
            <h4>新闻分类</h4>
            <ul>
                <li><a href="defaultme.aspx">首    页</a></li>
                <asp:Repeater ID="repCategory" runat="server">
                    <ItemTemplate>
                        <li><a href='list.aspx?caid=<%# Eval("id")%>'><%# Eval("name") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
