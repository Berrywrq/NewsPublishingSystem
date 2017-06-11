<%@ Page Title="新闻列表-News Publishing System" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="News_Publishing_System.list" %>
<%@ Register src="control/NewsCategory.ascx" tagname="NewsCategory" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!--新闻分类-->
        <uc1:NewsCategory ID="NewsCategory1" runat="server" />
        <!--新闻列表-->
        <div id="newslist" class="commonfrm">
            <h4><asp:Label ID="lblCaName" runat="server" Text="*"></asp:Label></h4>          
             <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" EmptyDataText="该类别下暂无新闻！">
                <Columns>
                    <asp:TemplateField HeaderText="所属类别" HeaderStyle-CssClass="th_category">
                    
                        <ItemTemplate>
                            <a class="td_category" href='list.aspx?caid=<%#Eval("caId") %>'>[<%# Eval("name") %>]</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="新闻标题">
                       
                        <ItemTemplate>
                            <a href='newscontent.aspx?newsid=<%#Eval("id") %>' target="_blank" title='<%#Eval("title") %>'><%# StringTruncat(Eval("title").ToString(),17,"...") %></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="发布时间" HeaderStyle-CssClass="th_time" ItemStyle-CssClass="td_time">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("createTime") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
              
            </asp:GridView>
        </div>
</asp:Content>
