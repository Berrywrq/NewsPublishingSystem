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
    public partial class modnews : System.Web.UI.Page
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
                    DataTable dt = new CategoryManager().SelectAll();
                    ddlCategory.DataSource = dt;
                    ddlCategory.DataTextField = "name";
                    ddlCategory.DataValueField = "id";
                    ddlCategory.DataBind();

                    //显示新闻标题和内容
                    string newsid = Request.QueryString["newsid"];
                    News n = new NewsManager().SelectById(newsid);
                    txtTitle.Text = n.Title;
                    ftbContent.Text = n.Content;
                    ddlCategory.SelectedValue = n.CaId;
                }
            }
            else
            {
                //未登录
                Response.Redirect("login.aspx");
            }
        }

        //修改新闻按钮
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string newsid = Request.QueryString["newsid"];
            string title = txtTitle.Text.Trim();
            string content = ftbContent.Text.Trim();
            string caid = ddlCategory.SelectedValue;

            News n = new News(newsid, title, content, caid);

            bool b = new NewsManager().Update(n);

            if (b)
            {
                Response.Write("<script>alert('新闻修改成功！')</script>");
            }
            else
            {
                Response.Write("新闻修改失败，请联系管理员！");
            }

            //清空标题和内容文本框中的内容
            txtTitle.Text = "";
            ftbContent.Text = "";
        }
    }
}