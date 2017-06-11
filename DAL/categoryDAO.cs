/*
*Author:Harry Wang
*CreateTime:2016/12/24 17:08
*Instruction:A class for category operate
*All Rights Reserved By HarryWang
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;//This sentence must be introduced here because of the using of DataTable
using Model;

namespace DAL
{
    /// <summary>
    /// 新闻类别表操作类
    /// </summary>
    public class CategoryDAO
    {
        private SQLHelper sqlhelper = null;
        public CategoryDAO()//Construction function
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 取出当前所有新闻分类
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from category";
            dt = sqlhelper.ExecuteQuery(sql,CommandType.Text);
            return dt;
        }

        /// <summary>
        /// 增加类别
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool Insert(string caName)//caName：前台文本框传入的参数
        {
            bool flag = false;
            string sql = "insert into category(name) values(@caName)";
            SqlParameter [] paras = new SqlParameter[]
            {
                new SqlParameter("@caName",caName)
            };
            int res = sqlhelper.ExecuteNonQuery(sql,paras,CommandType.Text);//重载
            if (res > 0)
            {
                return true;
            }
            return flag;
        }

        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别id</param>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool Update(Category ca)
        {

            bool flag = false;
            string sql = "update category set name=@caName where id=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",ca.ID),
                new SqlParameter("@caName",ca.Name)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras,CommandType.Text);//重载
            if (res > 0)
            {
                return true;
            }
            return flag;
        }

        /// <summary>
        /// 删除类别（连同其下新闻及新闻评论一起删除）
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <returns></returns>
        public bool Delete (string id)
        {
            bool flag = false;
            string sql = "delete from category where id=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras,CommandType.Text);//重载
            if (res > 0)
            {
                return true;
            }
            return flag;
        }

        /// <summary>
        /// 判别类别名称是否已经存在
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool isExists(string caName)
        {
            bool flag = false;
            string sql = "select * from category where name ='" + caName + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql,CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }

    }
}
