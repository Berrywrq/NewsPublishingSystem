/*
*Author:Harry Wang
*CreateTime:2016/12/24 17:05
*Instruction:A class to test commmand of sql
*All Rights Reserved By HarryWang
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SQLHelper
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataReader sdr = null;
        public SQLHelper()
        {
            String connStr = "server=.;database=NewsSystem;uid=sa;pwd=953606426";
            conn = new SqlConnection(connStr);

        }
        private SqlConnection GetConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            return conn;
        }
        /// <summary>
        /// 执行不带参数的增删改SQL语句或存储过程
        /// </summary>
        /// <param name="sql">增删改SQL语句或存储过程</param>
        /// <returns>命令类型</returns>
        public int ExecuteNonQuery(string cmdText,CommandType ct)
        {
            int res;
            try
            {
                cmd = new SqlCommand(cmdText, GetConn());
                cmd.CommandType = ct;
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }
        /// <summary>
        /// 执行带参数的增删改SQL语句或存储过程
        /// </summary>
        /// <param name="sql">增删改SQL语句或存储过程</param>
        /// <param name="paras">命令类型</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string cmdText,SqlParameter[]paras,CommandType ct)
        {
            int res;
            using (cmd = new SqlCommand(cmdText, GetConn()))
            {
                cmd.Parameters.AddRange(paras);
                cmd.CommandType = ct;
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }


        /// <summary>
        /// 执行查询SQL语句或存储过程
        /// </summary>
        /// <param name="sql">查询SQL语句或存储过程</param>
        /// <returns>命令类型</returns>
        public DataTable ExecuteQuery(string cmdText,CommandType ct)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand(cmdText, GetConn());
            cmd.CommandType = ct;
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }

        /// <summary>
        /// 执行带参数的查询SQL语句或存储过程
        /// </summary>
        /// <param name="sql">带参数的查询SQL语句或存储过程</param>
        /// <returns>命令类型</returns>
        public DataTable ExecuteQuery(string cmdText,SqlParameter[] paras, CommandType ct)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand(cmdText, GetConn());
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(paras);
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }
        public DataTable test(string procName)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand(procName, GetConn());
            cmd.CommandType = CommandType.StoredProcedure;//解释存储过程
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }

    }
}
