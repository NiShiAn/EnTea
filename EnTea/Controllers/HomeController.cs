using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnTea.Bll.User;

namespace EnTea.Controllers
{
    public class HomeController : Controller
    {
        private readonly Lazy<UserManager> _lazyUserManager = new Lazy<UserManager>();
        private UserManager UserManager => _lazyUserManager.Value;
        #region 用户登录
        /// <summary>
        /// 登录页
        /// </summary>
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        public ActionResult UserLogin(string name, string pass)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
                return Json("请填写登录信息", JsonRequestBehavior.AllowGet);

            var user = UserManager.UserLogin(name, pass);

            if (user == null)
                return Json("账号或密码错误", JsonRequestBehavior.AllowGet);


            return Json("dfd", JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}