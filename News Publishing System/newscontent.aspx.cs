using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace News_Publishing_System
{
    public partial class newscontent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string newsid = Request.QueryString["newsid"];
                NewsManager nm = new NewsManager();

                News news = nm.SelectById(newsid);

                //设置新闻主体            
                lblTitle.Text = news.Title;
                lblContent.Text = news.Content;
                lblCreateTime.Text = news.CreateTime;

                //绑定新闻评论
                DataTable dt = new CommentManager().SelectByNewsId(newsid);
                if (dt.Rows.Count == 0)
                {
                    //无新闻评论
                    emptydata.Visible = true;
                }
                else
                {
                    //有新闻评论
                    emptydata.Visible = false;
                }
                repComment.DataSource = dt;
                repComment.DataBind();
            }
        }
        //删除按钮
        protected void lbtnDelComment_Click(object sender, EventArgs e)
        {

            //当前点击的按钮
            LinkButton lb = (LinkButton)sender;
            //获取传过来的CommentId
            string comId = lb.CommandArgument;
            //删除该评论
            bool b = new CommentManager().Delete(comId);
            //重新绑定新闻评论
            if (b)
            {
                string newsid = Request.QueryString["newsid"];
                DataTable dt = new CommentManager().SelectByNewsId(newsid);
                if (dt.Rows.Count == 0)
                {
                    //无新闻评论
                    emptydata.Visible = true;
                }
                else
                {
                    //有新闻评论
                    emptydata.Visible = false;
                }
                repComment.DataSource = dt;
                repComment.DataBind();
            }
            else
            {
                Response.Write("<script>alert('评论删除失败！')</script>");
            }

        }

        //添加新闻评论
        protected void btnSub_Click(object sender, EventArgs e)
        {
            //判断验证码是否输入正确
            string code = txtCode.Text.Trim().ToUpper();
            string rightCode = Session["code"].ToString();
            if (code != rightCode)
            {
                Response.Write("<script>alert('验证码输入错误！')</script>");
                return;
            }

            //添加评论到数据库
            string com_content = txtComment.Text;
            string newsid = Request.QueryString["newsid"];
            string userIp = Request.UserHostAddress;
            Response.Write(userIp);
            Comment com = new Comment(com_content, userIp, newsid);
            bool b = new CommentManager().Insert(com);
            if (b)
            {
                //清空文本框
                txtCode.Text = "";
                txtComment.Text = "";

                //隐藏“该新闻暂无评论”
                emptydata.Visible = false;

                //重新绑定新闻评论               
                repComment.DataSource = new CommentManager().SelectByNewsId(newsid);
                repComment.DataBind();
            }
            else
            {
                Response.Write("<script>alert('评论添加失败！')</script>");
            }

        }

        //根据session的值显示或隐藏删除评论的按钮
        //逐条绑定的事件
        protected void repComment_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType==ListItemType.Item||e.Item.ItemType==ListItemType.AlternatingItem)//单数行||双数行
            {
                //判断session的值显示或隐藏删除按钮
                if (Session["admin"]!=null&&Session["admin"].ToString()=="Harry")
                {
                    ((LinkButton)e.Item.FindControl("lbtnDelComment")).Visible=true;
                }        
            }
        }
    }
}