﻿/*
*Author:Harry Wang
*CreateTime:2016/12/24 17:05
*Instruction:评论业务类
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
    public class CommentManager
    {
        private CommentDAO cdao = null;
        public CommentManager()
        {
            cdao = new CommentDAO();
        }
        /// <summary>
        /// 根据新闻ID取出该新闻的所有评论
        /// </summary>
        /// <param name="newsId">新闻Id</param>
        /// <returns></returns>
        public DataTable SelectByNewsId(string newsId)
        {
            return cdao.SelectByNewsId(newsId);
        }
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="c">评论实体类</param>
        /// <returns></returns>
        public bool Insert(Comment c)
        {
            return cdao.Insert(c);
        }

        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {

            return cdao.Delete(id);
        }
    }
}
