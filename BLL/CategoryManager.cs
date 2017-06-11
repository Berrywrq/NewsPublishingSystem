/*
*Author:Harry Wang
*CreateTime:2016/12/24 17:05
*Instruction:新闻类别表的业务类
*All Rights Reserved By HarryWang
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class CategoryManager
    {
        private CategoryDAO cdao = null;
        public CategoryManager()
        {
            cdao = new CategoryDAO();
        }


        /// <summary>
        /// 取出当前所有新闻分类
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            return cdao.SelectAll();
        }

        /// <summary>
        /// 增加类别
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool Insert(string caName)//caName：前台文本框传入的参数
        {
            return cdao.Insert(caName);
        }

        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别id</param>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool Update(Category ca)
        {
            return cdao.Update(ca);
        }

        /// <summary>
        /// 删除类别（连同其下新闻及新闻评论一起删除）
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return cdao.Delete(id);
        }

        /// <summary>
        /// 判别类别名称是否已经存在
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool isExists(string caName)
        {
            return cdao.isExists(caName);
        }

    }
}
