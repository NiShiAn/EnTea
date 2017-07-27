using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnTea.Dao;
using System.Configuration;
using EnTea.Com.Entity;

namespace EnTea.Bll.User
{
    public class UserManager
    {
        #region
        private readonly string _strCon = ConfigurationManager.ConnectionStrings["EnTeaSet"].ConnectionString;
        private readonly DalUser _dalUser;
        public UserManager()
        {
            _dalUser = new DalUser(_strCon);
        }
        #endregion

        #region 用户登录

        /// <summary>
        /// 用户登录判断
        /// </summary>
        public UserInfo UserLogin(string name, string pass)
        {
            return _dalUser.UserLogin(name, pass);
        }
        #endregion
    }
}
