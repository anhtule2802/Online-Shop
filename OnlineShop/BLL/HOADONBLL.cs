using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using PagedList;
namespace BLL
{
    public class HOADONBLL
    {
        ModelDBOnlineShopDbConText db = null;
        public HOADONBLL()
        {
            db = new ModelDBOnlineShopDbConText();
        }
        public int Insert(HOADON order)
        {
            db.HOADONs.Add(order);
            db.SaveChanges();
            return order.OrderID;
        }
        public HOADON ViewDetail(int orderID)
        {
            return db.HOADONs.Find(orderID);
        }
        public IEnumerable<HOADON> ListALL(int page, int pageSize)
        {
            return db.HOADONs.OrderByDescending(x => x.OrderID).Where(x => x.Status == "false").ToPagedList(page, pageSize);
        }
        public bool UpdateStatus(string status,int id)
        {
            var order = db.HOADONs.Find(id);
            order.Status = status;
            db.SaveChanges();
            return true;
        }
    }
}
