using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace News_Publishing_System.control
{
    public partial class NewsCategory : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //第一次进入该页面时
                //绑定新闻分类
                repCategory.DataSource = new CategoryManager().SelectAll();
                repCategory.DataBind();

            }
        }
    }
}