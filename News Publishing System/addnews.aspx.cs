using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Model;

namespace News_Publishing_System
{
    public partial class addnews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //判断session里面是否有管理员
            if (Session["admin"] != null && Session["admin"].ToString() == "Harry")
            {
                //已登录
                if (!Page.IsPostBack)
                {
                    //绑定新闻分类
                    DataTable dt=new CategoryManager().SelectAll();
                    ddlCategory.DataSource = dt;
                    ddlCategory.DataTextField = "name";
                    ddlCategory.DataValueField = "id";
                    ddlCategory.DataBind();
                }
            }
            else
            {
                //未登录
                Response.Redirect("login.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = ftbContent.Text.Trim();
            string caid = ddlCategory.SelectedValue;

            News n = new News(title,content,caid);

            bool b = new NewsManager().Insert(n);

            if (b)
            {
                Response.Write("新闻添加成功！");
            }
            else
            {
                Response.Write("新闻添加失败，请联系管理员！");
            }

            //清空标题和内容文本框中的内容
            txtTitle.Text = "";
            ftbContent.Text = "";
        }
    }
}