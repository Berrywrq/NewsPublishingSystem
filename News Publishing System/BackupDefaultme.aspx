<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BackupDefaultme.aspx.cs" Inherits="News_Publishing_System.Defaultme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>首页-News Publishing System</title>
    <link href="css/common.css" rel="stylesheet" />
</head>
<body>
<form id="form1" runat="server">
    <div id="top">
        <a href="http://www.baidu.com" target="_blank"><img src="images/Newsbanner760.jpg" /></a>
    </div>
    <div id="search">
        搜索条件：
        <asp:RadioButton ID="radTitle" GroupName="cond" runat="server" Text="标题" Checked="true" />
        <asp:RadioButton ID="radContent" GroupName="cond" runat="server" Text="内容" />
        <asp:TextBox ID="txtKey" runat="server" ></asp:TextBox>
        <asp:ImageButton ID="ibtnSearch" ImageUrl="/images/searchbtn25.png" runat="server" />
    </div>
    <div id="main">
        <!--新闻分类-->
        <div id="category" class="commonfrm">
            <h4>新闻分类</h4>
            <ul>
                <li><a href="#">首    页</a></li>
                <li><a href="#">体育新闻</a></li>
                <li><a href="#">财经新闻</a></li>
                <li><a href="#">社会新闻</a></li>
            </ul>
        </div>
        <!--最新新闻-->
        <div id="newnews" class="commonfrm">
            <h4>最新新闻</h4>
             <table>
                <tr>
                    <th class="th_category">所属类别</th>
                    <th>新闻标题</th>
                    <th class="th_time">发布时间</th>
                </tr>
                <tr>
                    <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
                <tr>
                   <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
                <tr>
                   <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
                <tr>
                   <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
                <tr>
                   <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
            </table>
        </div>
         <!--热点新闻-->
        <div id="hotnews" class="commonfrm">
            <h4>热点新闻</h4>
            <table>
                <tr>
                    <th class="th_category">所属类别</th>
                    <th>新闻标题</th>
                    <th class="th_time">发布时间</th>
                </tr>
                <tr>
                    <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
                <tr>
                   <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
                <tr>
                   <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
                <tr>
                   <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
                <tr>
                   <td><a href="#" class="td_category">[体育新闻]</a></td>
                    <td><a href="#">132456</a></td>
                    <td class="td_time">2017-4-3</td>
                </tr>
            </table>
        </div>
    </div>
    <div id="footer">copyright &copy; <a href="http://www.baidu.com">HarryWang</a></div>
</form>
</body>
</html>
