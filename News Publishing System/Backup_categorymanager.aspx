<%@ Page Title="类别管理" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="Backup_categorymanager.aspx.cs" Inherits="News_Publishing_System.categorymanager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/manager_common.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="m_category" class="round2">
        <h3>管理中心</h3>
        <div class="con">
            <p><a href="categorymanager.axpx">类别管理</a></p>
            <p><a href="newsmananger.aspx"></a>新闻管理</p>
            <p><a href="addnews.aspx"></a>添加新闻</p>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
        </div>
    </div>
    <div id="camanager" class="round2">
        <h3>类别管理</h3>
        <div class="con">
            <div class="fontcolor">提示：点击类别名称后可直接修改，回车或点击页面其他地方后修改生效！</div>
           <table class="m_table">
               <tr>
                   <th class="id">序号</th>
                   <th>类别名称</th>
                   <th class="oper">操作</th>
               </tr>
               <tr>
                   <td>1</td>
                   <td>体育新闻</td>
                   <td><a href="#">删除</a></td>
               </tr>
               <tr>
                   <td>1</td>
                   <td>体育新闻</td>
                   <td><a href="#">删除</a></td>
               </tr>
               <tr>
                   <td>1</td>
                   <td>体育新闻</td>
                   <td><a href="#">删除</a></td>
               </tr>
           </table>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
        </div>
    </div>
    <div id="addca" class="round2">
        <h3>添加类别</h3>
        <div class="con">
           请输入类别名称：<asp:TextBox ID="txtCaname" runat="server" BorderColor="#A1C3E9" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" Text="添加类别" />
        </div>
        <div class="footer">
            <p>&nbsp;</p>
        </div>
    </div>
</asp:Content>
