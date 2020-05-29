using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
namespace BLL
{
    public class CHITIETHOADONBLL
    {
        ModelDBOnlineShopDbConText db = null;
        public CHITIETHOADONBLL()
        {
            db = new ModelDBOnlineShopDbConText();
        }
        public bool Insert(CHITIETHOADON detail)
        {
            try
            {
                db.CHITIETHOADONs.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
