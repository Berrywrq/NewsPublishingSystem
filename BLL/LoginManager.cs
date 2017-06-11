/*
*Author:HarrywWang
*Discribe:登录的业务逻辑类
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class LoginManager
    {
        #region 用户登录是否成功 
        /// <summary>
        /// 用户登录是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public static bool Login(string name, string pwd)
        {
            bool flag = false;
            if ("Harry" == name && "E10ADC3949BA59ABBE56E057F20F883E" == pwd)
            {
                flag = true;
            }
            return flag;
        }
        #endregion


    }
}
