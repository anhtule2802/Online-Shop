using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.EF;
using BLL;
using PagedList;
namespace WebThietBiMang.Areas.Admin.Controllers
{
    public class ManagerAccountController : Controller
    {
        // GET: Admin/ManagerAccount
        public ActionResult Index(int page = 1 , int pageSize= 5)
        {
            var accBLL = new NGUOIDUNGBLL();
            var model = accBLL.ListALL(page, pageSize);
            return View(model);
        }
        public ActionResult UpdateOrder(int id)
        {
            var ndBLL = new NGUOIDUNGBLL();
            ndBLL.UpdateStatus("true", id);
            return Redirect("/Admin/ManagerAccount/Index");
        }
    }
}