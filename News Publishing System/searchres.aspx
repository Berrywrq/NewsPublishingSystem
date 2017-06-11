<%@ Page Title="搜索结果-News Publishing System" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="searchres.aspx.cs" Inherits="News_Publishing_System.serach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 730px;
            height: 255px;
        }
        .auto-style2 {
            width: 280px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--搜索结果-->
        <div id="searchres" class="commonfrm">
            <h4>搜索结果</h4>
              <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" >
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
