using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.EF;
using BLL;
using WebThietBiMang.Areas.Admin.Models;
using WebThietBiMang.Common;

namespace WebThietBiMang.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var Dal = new NGUOIDUNGBLL();
                var result = Dal.Login(model.UserName, model.Password);
                if (result==-1)
                {
                    var user = Dal.GetbyId(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.Username;
                    userSession.UserID = user.Id;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    if (result == 0)
                    {
                        ModelState.AddModelError("", "Bạn Không Có Quyền Đăng Nhập Trang Này");
                    }
                    else if (result == -2)
                    {
                        ModelState.AddModelError("", "Tài Khoản Của Bạn Chưa Được Kích Hoạt");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng Nhập Sai Tài Khoản Hoặc Mật Khẩu");
                    }
                }
            }
             return View("Index");
        }
    }
}