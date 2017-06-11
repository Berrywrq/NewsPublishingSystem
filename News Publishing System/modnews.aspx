<%@ Page Title="修改新闻_后台管理" Language="C#" MasterPageFile="~/m_common.master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="modnews.aspx.cs" Inherits="News_Publishing_System.modnews" %>
<%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="m_contentPlaceHolder" runat="server">
     <div id="addnews" class="round2">
        <h3>修改新闻</h3>
         
        <div class="con">
            <p>
                新闻分类：<asp:DropDownList ID="ddlCategory" BorderColor="#BEDDFE" BorderStyle="Solid" BorderWidth="1px" runat="server"></asp:DropDownList>
            </p>
            <p>新闻标题：<asp:TextBox ID="txtTitle" runat="server" CssClass="newstitle" BackColor="#EFF7FF" BorderColor="#BEDDFE" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            </p>
            <p>新闻内容：<FTB:FreeTextBox  ToolbarStyleConfiguration="OfficeMac" ID="ftbContent"
                Language="zh-CN" Width="500" Height="200" runat="server">
                </FTB:FreeTextBox>
            </p>
            <%--<p>
                <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" CssClass="newscontent" BackColor="#EFF7FF" BorderColor="#BEDDFE" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>

            </p>        --%>&nbsp;<p><asp:Button ID="btnAdd" runat="server" Text="修改新闻" BackColor="#ABCDF3" BorderStyle="Double" BorderWidth="1px" OnClick="btnAdd_Click" /></p>      
        </div>
        <div class="footer">
            <p>&nbsp;</p>
        </div>
    </div>
</asp:Content>
