<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="News_Publishing_System.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>后台登录</title>
    <link href="css/login.css" rel="stylesheet" />
    <script type="text/javascript">
        function changeCode() {
            var imgNode = document.getElementById("vimg");
            imgNode.src = "handler/WaterMark.ashx?t=" + (new Date()).valueOf();//这里价加个时间参数是为了防止浏览器缓存的问题
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="loginfrm" class="round1">
       <h3>后台登录-News Publishing System</h3>
        <div id="login">
            <img src="images/niunanlogo.jpg" class="login_logo" alt="LOGO" />
            <p>用户名：<asp:TextBox ID="txtUserName" runat="server" CssClass="txtbox"></asp:TextBox></p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入用户名！" Text="*" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
            <p>密  码：  <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="txtbox"></asp:TextBox></p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码！" Text="*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            <p>验证码：<img src="handler/WaterMark.ashx" id="vimg" alt="" onclick="changeCode()" />
                <asp:TextBox ID="txtCode" runat="server" CssClass="txtcode"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入验证码！" Text="*" ControlToValidate="txtCode"></asp:RequiredFieldValidator></p>            
            <p><asp:Button ID="btnLogin" runat="server" Text="登陆" OnClick="btnLogin_Click" /></p>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" />

            
        </div>
        <div id="footer">copyright &copy;<a href="http://www.baidu.com" target="_blank"> HarryWang</a></div>
    
    </div>
    </form>
</body>
</html>
