using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebThietBiMang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "Add Cart",
               url: "gio-hang",
               defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
               namespaces: new[] { "WebThietBiMang.Controllers" }
           );
            routes.MapRoute(
               name: "Update Order",
               url: "update-order",
               defaults: new { controller = "ManagerOrder", action = "UpdateOrder", id = UrlParameter.Optional },
               namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
                name: "Update Account",
                url: "update-account",
                defaults: new { controller = "ManagerAccount", action = "UpdateOrder", id = UrlParameter.Optional },
                namespaces: new[] { "WebThietBiMang.Controllers" }
                );
            routes.MapRoute(
                name: "Delete Product",
                url: "xoa-san-pham",
                defaults: new { controller = "ManagerProduct", action = "DeleteProduct", id = UrlParameter.Optional },
                namespaces: new[] { "WebThietBiMang.Controllers" }
                );
            routes.MapRoute(
               name: "Update Cart",
               url: "update-gio-hang",
               defaults: new { controller = "Cart", action = "UpdateItem", id = UrlParameter.Optional },
               namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
               name: "Payment",
               url: "thanh-toan",
               defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional },
               namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
               name: "Finish Payment",
               url: "hoan-thanh",
               defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional },
               namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
               name: "Delete Cart",
               url: "gio-hang-xoa",
               defaults: new { controller = "Cart", action = "DeleteItem", id = UrlParameter.Optional },
               namespaces: new[] { "WebThietBiMang.Controllers" }
           );
            routes.MapRoute(
                name: "Product Detail",
                url: "chi-tiet/{metatitle}-{id}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
                name: "Product",
                url: "san-pham",
                defaults: new { controller = "Product", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
                name: "Register",
                url: "dang-ky",
                defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional },
                namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
                name: "Login",
                url: "dang-nhap",
                defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
                name: "Product Category",
                url: "san-pham/{metatitle}-{id}",
                defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
                namespaces: new[] { "WebThietBiMang.Controllers" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebThietBiMang.Controllers" }
            );
        }
    }
}
