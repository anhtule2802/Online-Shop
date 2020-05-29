using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebThietBiMang.Models;
using BLL;
using DAL.EF;
using WebThietBiMang.Common;
namespace WebThietBiMang.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session[CommonConstants.USER_SESSION] = null;
            return Redirect("/");
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var Dal = new NGUOIDUNGBLL();
                var result = Dal.Login(model.UserName, model.Password);
                if (result==0)
                {
                    var user = Dal.GetbyId(model.UserName);
                    var userSession = new UserLogin();//gán session
                    userSession.UserName = user.Username;
                    userSession.UserID = user.Id;                    
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return Redirect("/");
                }
                else
                {
                    if (result == -1)
                    {
                        ModelState.AddModelError("", "Bạn Không Có Quyền Đăng Nhập Trang Này");
                    }
                    else if(result == -2)
                    {
                        ModelState.AddModelError("", "Tài Khoản Của Bạn Chưa Được Kích Hoạt");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng Nhập Sai Tài Khoản Hoặc Mật Khẩu");
                    }
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if(ModelState.IsValid)
            {
                var ngdung = new NGUOIDUNGBLL();
                if(ngdung.CheckUserName(model.UserName))//Check username có tồn tài không
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if(ngdung.CheckEmail(model.Email))//Check Email có tồn tại không
                {
                    ModelState.AddModelError("", "Email đã tồn tại");
                }
                else
                {
                    var user = new NGUOIDUNG();
                    user.Id = model.Id;
                    user.Username = model.UserName;
                    user.Password = model.Password;
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Email = model.Email;
                    user.Role = "Customer";
                    user.Status = "false";
                    var result = ngdung.Insert(user);
                    if(result>0) //nếu result lớn hơn 0 thì thêm thành công
                    {
                        ViewBag.Success = "Đăng Ký Thành Công";
                        model = new RegisterModel();
                    }
                    else
                    {
                        ModelState.AddModelError("","Đăng ký không thành công");
                    }
                }
            }
            return View(model);
        }
    }
}