using EnTea.Com.Entity;
using EnTea.Com;
using SqlSugar;

namespace EnTea.Dao
{
    public class DalUser
    {
        #region 构造函数
        private readonly SqlSugarClient _dbManage;

        public DalUser(string strConn)
        {
            _dbManage = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = strConn,
                DbType = DbType.SqlServer
            });
        }
        #endregion

        #region 用户登录
        /// <summary>
        /// 用户登录判断
        /// </summary>
        public UserInfo UserLogin(string name, string pass)
        {
            var md5Pass = ComTools.ToMd5(pass);
            return _dbManage.Queryable<UserInfo>()
                .Where(n => (n.UserName == name || n.Tel == name || n.Email == name) && n.Pass == md5Pass)
                .First();
        }
        #endregion
    }
}
