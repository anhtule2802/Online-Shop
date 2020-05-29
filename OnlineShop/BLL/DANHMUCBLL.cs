using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
namespace BLL
{
    public class DANHMUCBLL
    {
        ModelDBOnlineShopDbConText db = null;
        public DANHMUCBLL()
        {
            db = new ModelDBOnlineShopDbConText();
        }
        public List<DANHMUC> ListAll()
        {
            return db.DANHMUCs.OrderBy(x => x.Sorting).ToList();
        }
        public DANHMUC ViewDetail(int id)
        {
            return db.DANHMUCs.Find(id);
        }
        public int GetIDByName(string name)
        {
            var result = db.DANHMUCs.SingleOrDefault(x => x.Name == name);
            return result.CategoryID;
        }
    }
}
