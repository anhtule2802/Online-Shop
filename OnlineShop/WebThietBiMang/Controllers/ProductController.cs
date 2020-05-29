using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.EF;
using BLL;
namespace WebThietBiMang.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()//Trả về view các sản phẩm mới nhất
        {
            var sanpham = new SANPHAMBLL();
            ViewBag.Products = sanpham.ListProduct(9);
            return View();
        }
        [ChildActionOnly]
        public ActionResult ProductCategory()//Trả về view cột danh mục sản phẩm
        {
            var model = new DANHMUCBLL().ListAll();
            return PartialView(model);
        }
        public ActionResult Category(int id)//Trả về view những sản phẩm của danh mục đã chọn
        {
            var category = new DANHMUCBLL().ViewDetail(id);
            var sanpham = new SANPHAMBLL();
            ViewBag.ProductsID = sanpham.ListProductID(id);
            return View(category);
        }
        public ActionResult Detail(int id)//Trả về view chi tiết sản phẩm
        {
            var product = new SANPHAMBLL().ViewDetail(id);
            var sanpham = new SANPHAMBLL();
            ViewBag.ProductsID = sanpham.ListProductIDCount(product.CategoryID.Value,3);
            ViewBag.Category = new DANHMUCBLL().ViewDetail(product.CategoryID.Value);
            return View(product);
        }
    }
}