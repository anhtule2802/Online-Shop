using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using PagedList;
namespace BLL
{
    public class SANPHAMBLL
    {
        ModelDBOnlineShopDbConText db = null;
        public SANPHAMBLL()
        {
            db = new ModelDBOnlineShopDbConText();
        }
        public List<SANPHAM> ListProduct(int sl)//trả về số lượng sản phẩm sắp xếp theo ngày
        {
            return db.SANPHAMs.OrderByDescending(x => x.CreateDays).Take(sl).ToList();
        }
        public List<SANPHAM> ListProductID(int categoryID)//trả về sản phẩm có cùng danh mục và sắp xếp theo ngày
        {
            return db.SANPHAMs.Where(x => x.CategoryID == categoryID).OrderByDescending(x=>x.CreateDays).ToList();
        }
        public List<SANPHAM> ListProductIDCount(int categoryID,int sl)//trả về sản phẩm liên quan trong product detail
        {
            return db.SANPHAMs.Where(x => x.CategoryID == categoryID).Take(sl).ToList();
        }
        public SANPHAM ProductByID(int productID)//trả về sản phẩm có cùng id
        {
            return db.SANPHAMs.SingleOrDefault(x=>x.Id==productID);
        }
        public SANPHAM ViewDetail(int id)
        {
            return db.SANPHAMs.Find(id);
        }
        public IEnumerable<SANPHAM> ListALL(int page,int pageSize)
        {
            return db.SANPHAMs.OrderByDescending(x=>x.CreateDays).ToPagedList(page,pageSize);
        }
        public int Insert(SANPHAM sp)
        {
            db.SANPHAMs.Add(sp);
            db.SaveChanges();
            return sp.Id;
        }
        public bool Delete(int id)
        {
            var result = db.SANPHAMs.Find(id);
            db.SANPHAMs.Remove(result);
            db.SaveChanges();
            return true;       
        }
        public bool Update(SANPHAM sp)
        {
            var product = db.SANPHAMs.Find(sp.Id);
            int categoryID = new DANHMUCBLL().GetIDByName(sp.CategoryName);
            product.Name = sp.Name;
            product.Description = sp.Description;
            product.Price = sp.Price;
            product.CategoryName = sp.CategoryName;
            product.ImageName = sp.ImageName;
            product.MetaTitle = sp.MetaTitle;
            product.CreateDays = DateTime.Now;
            product.CategoryID = categoryID;
            db.SaveChanges();
            return true;
        }
    }
}
