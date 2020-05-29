using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.EF;
namespace WebThietBiMang.Models
{
    [Serializable]
    public class CartItem
    {
        public SANPHAM Product { set; get; }
        public int Quantity { set; get;}
    }
}