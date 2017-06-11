using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace News_Publishing_System
{
    public partial class categorymanager1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断session里面是否存在管理员
            if (Session["admin"]!=null&&Session["admin"].ToString()=="Harry")
            {
                //已登录
                if (!Page.IsPostBack)
                {
                    //页面第一次加载时，绑定类别列表
                    DataTable dt = new CategoryManager().SelectAll();
                    repCategory.DataSource = dt;
                    repCategory.DataBind();
                }
            }
            else
            {
                //未登录
                Response.Redirect("login.aspx");
            }
        }

        //添加类别
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager();
            string name = txtCaname.Text.Trim();
            //判断类别明是否已经存在
            if (cm.isExists(name))
            {
                Response.Write("<script>alert('类别名称已经存在！')</script>");
                txtCaname.Text = "";
                return;
            }

            //添加类别
            bool b=cm.Insert(name);
            if (b)
            {
                //清空文本框
                txtCaname.Text = "";

                //添加成功，重新绑定类别列表
                DataTable dt = cm.SelectAll();
                repCategory.DataSource = dt;
                repCategory.DataBind();
            }
            else
            {
                Response.Write("<script>alart('类别添加失败！')</script>");
            } 
        }
        //删除按钮
        protected void lbtnDelCa_Click(object sender, EventArgs e)
        {

            //当前点击的按钮
            LinkButton lb = (LinkButton)sender;
            //获取传过来的CaId
            string caId = lb.CommandArgument;
            //删除该类别
            bool b = new CategoryManager().Delete(caId);
            //重新绑定新闻评论
            if (b)
            {
                //重新绑定新闻类别
                DataTable dt = new CategoryManager().SelectAll();
                repCategory.DataSource = dt;
                repCategory.DataBind();
            }
            else
            {
                Response.Write("<script>alert('类别删除失败！')</script>");
            }

        }
    }


}