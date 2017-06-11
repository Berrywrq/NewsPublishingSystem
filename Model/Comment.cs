using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*Author : Harrywang
*CreateTime : 2016-1-1
*Description : 新闻类别实体类
*/

namespace Model
{
    /// <summary>
    /// 新闻评论实体类
    /// </summary>
   public class Comment
    {
        private string id;
        /// <summary>
        /// 主键，自增
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string content;
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string userIp;
        /// <summary>
        /// 用户Ip
        /// </summary>
        public string UserIp
        {
            get { return userIp; }
            set { userIp = value; }
        }
        private string createTime;
        /// <summary>
        /// 评论发表时间
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private string newsId;
        /// <summary>
        /// 所属新闻Id
        /// </summary>
        public string NewsId
        {
            get { return newsId; }
            set { newsId = value; }
        }

        public Comment() { }
        public Comment(string content,string userIp,string newsId)
        {
            this.content = content;
            this.userIp = userIp;
            this.newsId = newsId;
        }
    }
}
