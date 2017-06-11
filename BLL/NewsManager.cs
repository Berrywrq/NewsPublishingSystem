/*
*Author:Harry Wang
*CreateTime:2016/12/24 17:05
*Instruction:新闻业务类
*All Rights Reserved By HarryWang
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class NewsManager
    {
        private NewsDAO ndao = null;
        public NewsManager()
        {
            ndao = new NewsDAO();
        }

        #region 选择全部新闻
        /// <summary>
        /// 选择全部新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll() {
            return ndao.SelectAll();        
        }
        #endregion

        /// <summary>
        /// 取出10条最新新闻（所属分类，新闻标题，发布时间）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewNews()
        {
            return ndao.SelectNewNews();
        }

        /// <summary>
        /// 取出10条热点新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectHotNews()
        {
            return ndao.SelectHotNews();
        }

        /// <summary>
        /// 根据类别ID取出该类别下的所有新闻
        /// </summary>
        /// <param name="caid"></param>
        /// <returns></returns>
        public DataTable SelectByCaId(string caid)
        {
            return ndao.SelectByCaId(caid);
        }

        /// <summary>
        /// 根据新闻ID取出该条新闻的主体内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回News对象</returns>
        public News SelectById(string id)
        {
            return ndao.SelectById(id);
        }

        /// <summary>
        /// 根据标题搜索新闻
        /// </summary>
        /// <param name="title">新闻标题关键字</param>
        /// <returns></returns>
        public DataTable SelectByTitle(string title)
        {
            return ndao.SelectByTitle(title);
        }

        /// <summary>
        /// 根据内容搜索新闻
        /// </summary>
        /// <param name="content">内容关键字</param>
        /// <returns></returns>
        public DataTable SelectByContent(string content)
        {
            return ndao.SelectByContent(content);
        }

        /// <summary>
        /// 增加新闻
        /// </summary>
        /// <param name="n">新闻实体类</param>
        /// <returns></returns>
        public bool Insert(News n)
        {
            return ndao.Insert(n);
        }

        /// <summary>
        /// 修改新闻
        /// </summary>
        /// <param name="n">新闻实体类</param>
        /// <returns></returns>
        public bool Update(News n)
        {
            return ndao.Update(n);
        }

        /// <summary>
        /// 删除新闻（连同其下新闻评论一起删除）
        /// </summary>
        /// <param name="n">新闻ID</param>
        /// <returns></returns>
        public bool Delete(string n)
        {
            return ndao.Delete(n);
        }
    }
}
