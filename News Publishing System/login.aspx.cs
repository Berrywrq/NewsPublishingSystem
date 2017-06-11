using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Web.Security;

namespace News_Publishing_System
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //判断验证码是否输入正确
            string code = txtCode.Text.Trim().ToUpper();
            string rightCode = Session["code"].ToString();
            if (code != rightCode)
            {
                Response.Write("<script>alert('验证码输入错误！')</script>");
                return;
            }

            string name = txtUserName.Text.Trim();
            string pwd = txtPassword.Text.Trim();

            // 把密码转为MD5码的形式
            pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");

            //判断用户名和密码是否正确
            bool b=LoginManager.Login(name, pwd);
            if (b)
            {
                //登录成功
                Session["admin"] = name;
                Response.Redirect("categorymanager.aspx");
               
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
            }


            

        }
    }
}