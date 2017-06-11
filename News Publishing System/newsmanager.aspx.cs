using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace News_Publishing_System
{
    public partial class newsmanager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断session里面是否有管理员
            if (Session["admin"] != null && Session["admin"].ToString() == "Harry")
            {
                //已登录
                if (!Page.IsPostBack)
                {
                    BindNews();
                }
            }else
            {
                //未登录
                Response.Redirect("login.aspx");
            }
        }
        //删除按钮
        protected void lbtnDel_Click(object sender, EventArgs s)
        {
            string id = ((LinkButton)sender).CommandArgument;
            bool b = new NewsManager().Delete(id);
            BindNews();
            if (b)
            {
                BindNews();
            }
            else
            {
                Response.Write("<script>alert('验证码输入错误！')</script>");
            }
        }

        #region 绑定新闻列表
        private void BindNews()
        {
            repNews.DataSource = new NewsManager().SelectAll();
            repNews.DataBind();
        }
        #endregion
    }
}