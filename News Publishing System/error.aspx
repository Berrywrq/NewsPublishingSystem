<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="News_Publishing_System.error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>出错啦</title>
    <link href="css/login.css" rel="stylesheet" />
    <script type="text/javascript">
        var i = 5;
        var intervalid;
        inervarid = setInterval("fun()", 1000);
        function fun() {
            if (i == 0) {
                window.location.href = "Defaultme.aspx";
                clearInterval(intervalid);
            }
            document.getElementById("mes").innerHTML = i;
            i--;
        }
    </script>
</head>
<body>
    <div id="errorfrm" class="round1">
        <h3>出错啦</h3>
        <div id="error">
            <img src="images/error.gif" alt="image"/>
            <p>系统出错，请联系管理员！</p>
            <p>将在 <span id="mes">5</span> 秒钟后返回首页</p>
            
        </div>
        <div id="footer">copyright &copy;<a href="http://www.baidu.com" target="_blank"> HarryWang</a></div>

    </div>
</body>
</html>
