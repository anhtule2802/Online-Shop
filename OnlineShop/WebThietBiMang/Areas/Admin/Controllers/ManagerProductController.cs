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
    public class ManagerProductController : Controller
    {
        // GET: Admin/ManagerProduct
        public ActionResult Index(int page = 1, int pageSize = 5)
        {
            var spBLL = new SANPHAMBLL();
            var model = spBLL.ListALL(page, pageSize);
            return View(model);
        }
        public ActionResult EditProduct(int productID)
        {
            ViewBag.ListProduct = new SANPHAMBLL().ProductByID(productID);
            ViewBag.ListDanhMuc = new DANHMUCBLL().ListAll();
            return View();
        }
        [HttpPost]
        public ActionResult EditProduct(string Id,string NamePd, string Description, string Price, string danhmuc, string ImageName, string MetaTitle)
        {
            SANPHAM sp = new SANPHAM();
            sp.Id = Convert.ToInt32(Id);
            sp.Name = NamePd;
            sp.Description = Description;
            sp.Price = Convert.ToInt32(Price);
            sp.CategoryName = danhmuc;
            sp.ImageName = ImageName;
            sp.MetaTitle = MetaTitle;
            var update = new SANPHAMBLL().Update(sp);
            return Redirect("/Admin/ManagerProduct/Index"); 
        }
        public ActionResult AddNewProduct()
        {
           ViewBag.ListDanhMuc = new DANHMUCBLL().ListAll();
           return View();
        }
        [HttpPost]
        public ActionResult AddNewProduct(string NamePd,string Description,string Price,string danhmuc,string ImageName,string MetaTitle)
        {
            var newproduct = new SANPHAM();
            newproduct.CategoryID = new DANHMUCBLL().GetIDByName(danhmuc);
            newproduct.Name = NamePd;
            newproduct.Description = Description;
            newproduct.Price = Convert.ToInt32(Price);
            newproduct.CategoryName = danhmuc;
            newproduct.ImageName = ImageName;
            newproduct.MetaTitle = MetaTitle;
            newproduct.CreateDays = DateTime.Now;
            var insert = new SANPHAMBLL().Insert(newproduct);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int productID)
        {
            var spBLL = new SANPHAMBLL();
            spBLL.Delete(productID);
            return Redirect("/Admin/ManagerProduct/Index");
        }
    }
}