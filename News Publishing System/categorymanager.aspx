<%@ Page Title="后台-类别管理" Language="C#" MasterPageFile="~/m_common.master" AutoEventWireup="true" CodeBehind="categorymanager.aspx.cs" Inherits="News_Publishing_System.categorymanager1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="m_contentPlaceHolder" runat="server">
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
                <asp:Repeater ID="repCategory" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("id") %></td>
                            <td class="caname">
                                <%#Eval("name") %></td>
                            <td>
                                <asp:LinkButton ID="lbtnDelCa" runat="server" CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm('删除类别会使其下新闻及其评论全都删除，是否真的要删除该类别？')" OnClick="lbtnDelCa_Click">删除</asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <div id="test"></div>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
        </div>
    </div>
    <div id="addca" class="round2">
        <h3>添加类别</h3>
        <div class="con">
            请输入类别名称：<asp:TextBox ID="txtCaname" runat="server" ValidationGroup="addCa" BorderColor="#A1C3E9" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="addCa" ErrorMessage="请输入类别名称！" Text="*" ControlToValidate="txtCaname"></asp:RequiredFieldValidator>
            <asp:Button ID="btnAdd"  UseSubmitBehavior="false" ValidationGroup="addCa" runat="server" Text="添加类别" OnClick="btnAdd_Click" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="addCa" ShowMessageBox="true" ShowSummary="false"/>
        </div>
        
        
        <div class="footer">
            <p>&nbsp;</p>
        </div>
    </div>
</asp:Content>
