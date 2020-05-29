using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebThietBiMang.Models;
using BLL;
using DAL.EF;
namespace WebThietBiMang.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if(cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }
        public ActionResult Payment()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }
        [HttpPost]
        public ActionResult Payment(string ShipName, string ShipMobile,string ShipAddress, string ShipEmail)
        {
            var session = (WebThietBiMang.Common.UserLogin)Session[WebThietBiMang.Common.CommonConstants.USER_SESSION];
            var order = new HOADON();
            order.UserID = session.UserID;
            order.ShipName = ShipName;
            order.ShipMobile = ShipMobile;
            order.ShipAddress = ShipAddress;
            order.ShipEmail = ShipEmail;
            order.CreateAt = DateTime.Now;
            order.Status = "false";
            var id = new HOADONBLL().Insert(order);
            var cart = (List<CartItem>)Session[CartSession];
            var detail = new CHITIETHOADONBLL();
            foreach(var item in cart)
            {
                var chitiethoadon = new CHITIETHOADON();
                chitiethoadon.ProductID = item.Product.Id;
                chitiethoadon.OrderID = id;
                chitiethoadon.Quantity = item.Quantity;
                chitiethoadon.Price = Convert.ToInt32(item.Product.Price * item.Quantity);
                chitiethoadon.UserID = session.UserID;
                detail.Insert(chitiethoadon);
            }
            foreach(var item in cart)
            {
                if(cart.Count>0)
                {
                    cart.RemoveRange(cart.IndexOf(item), cart.Count);
                }
                if(cart.Count==0)
                {
                    break;
                }
            }
            return Redirect("/hoan-thanh");
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult UpdateItem(int productID)
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            ViewBag.ProductByID = new SANPHAMBLL().ProductByID(productID);
            return View(list);
        }
        [HttpPost]
        public ActionResult UpdateItem(int productID,int soluong)
        {
            var product = new SANPHAMBLL().ViewDetail(productID);
            var cart = Session[CartSession];
            var list = (List<CartItem>)cart;
            if (cart != null)
            {
                if (list.Exists(x => x.Product.Id == productID))//tồn tại sp trong giỏ hàng
                {
                    foreach (var item in list)
                    {
                        if (item.Product.Id == productID)
                        {
                            item.Quantity = soluong;
                        }
                    }
                }
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteItem(int productID)//Xóa giỏ hàng
        {
            var product = new SANPHAMBLL().ViewDetail(productID);
            var cart = Session[CartSession];
            var list = (List<CartItem>)cart;
            if(cart!=null)
            {
               if (list.Exists(x => x.Product.Id == productID))//tồn tại sp trong giỏ hàng
                 {
                        foreach (var item in list)
                        {
                            if(item.Product.Id==productID)
                            {
                                list.RemoveAt(list.IndexOf(item));
                                break;
                            }
                        }
                 }                
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
        public ActionResult AddItem(int productID, int quantity)//Thêm giỏ hàng
        {
            var product = new SANPHAMBLL().ViewDetail(productID);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if(list.Exists(x=>x.Product.Id==productID)) //Nếu tốn tại ID sản phẩm trong giỏ hàng
                {
                    foreach (var item in list)
                    {
                        if (item.Product.Id == productID)
                        {
                            item.Quantity += quantity; // Số lượng +1
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.Product = product;
                    item.Quantity = quantity;
                    list.Add(item);
                }
                //Gán vào session
                Session[CartSession] = list;
            }
            else
            {
                // Tạo mới đối tượng cart item
                var item = new CartItem();
                item.Product = product;
                item.Quantity = quantity;
                var list = new List<CartItem>();
                list.Add(item);
                //Gán vào session
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
    }
}