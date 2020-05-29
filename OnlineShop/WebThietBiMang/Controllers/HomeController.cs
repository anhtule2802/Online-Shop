using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using WebThietBiMang.Models;

namespace WebThietBiMang.Controllers
{
    public class HomeController : Controller
    {
        private const string CartSession = "CartSession";
        public ActionResult Index()
        {
            var sanpham = new SANPHAMBLL();
            ViewBag.Products = sanpham.ListProduct(6);
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult HeaderCart()
        {
            var cart = Session[WebThietBiMang.Common.CommonConstants.CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return PartialView(list);
        }
        public ActionResult Product()
        { 
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}