using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DAL.EF;
using PagedList;
namespace WebThietBiMang.Areas.Admin.Controllers
{
    public class ManagerOrderController : Controller
    {
        // GET: Admin/ManagerOrder
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var orderBLL = new HOADONBLL();
            var model = orderBLL.ListALL(page, pageSize);
            return View(model);
        }
        public ActionResult UpdateOrder(int id)
        {
            var hdBLL = new HOADONBLL();
            hdBLL.UpdateStatus("true",id);
            return Redirect("/Admin/ManagerOrder/Index");
        }
    }
}