<%@ Page Title="后台-新闻管理" Language="C#" MasterPageFile="~/m_common.master" AutoEventWireup="true" CodeBehind="newsmanager.aspx.cs" Inherits="News_Publishing_System.newsmanager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="m_contentPlaceHolder" runat="server">
    <div id="newsmanager" class="round2">
        <h3>新闻管理</h3>
        <div class="con">
            <div class="fontcolor">提示：点击类别名称后可进行对该新闻评论的删除！</div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table class="m_table">
                        <tr>
                            <th class="id">序号</th>
                            <th>标题</th>
                            <th class="oper">修改</th>
                            <th class="oper">操作</th>
                        </tr>
                        <asp:Repeater ID="repNews" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("id") %></td>
                                    <td><a href='../newscontent.aspx?newsid=<%#Eval("id") %>' target="_blank"><%#Eval("title") %></a></td>
                                    <td><a href="modnews.aspx?newsid=<%#Eval("id") %>" target="_blank">修改</a></td>
                                    <td>
                                        <asp:LinkButton ID="lbtn_Del" OnClientClick="return confirm('删除新闻会连同其下评论一起删除，是否删除？')" OnClick="lbtnDel_Click" CommandArgument='<%#Eval("id") %>' runat="server">删除</asp:LinkButton></td>
                                </tr>
                            </ItemTemplate>

                        </asp:Repeater>


                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
        </div>
    </div>
</asp:Content>
