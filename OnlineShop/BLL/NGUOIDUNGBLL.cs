using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using PagedList;
namespace BLL
{
    public class NGUOIDUNGBLL
    {
        ModelDBOnlineShopDbConText db = null;
        public NGUOIDUNGBLL()
        {
            db = new ModelDBOnlineShopDbConText();
        }
        public NGUOIDUNG GetbyId(string UserName)
        {
            return db.NGUOIDUNGs.SingleOrDefault(x => x.Username == UserName);
        }
        public int Login(string username, string password) //Kiểm đăng nhập
        {
            int result = db.NGUOIDUNGs.Count(x => x.Username == username && x.Password == password);
            if (result > 0)
            {
                int role = db.NGUOIDUNGs.Count(y => y.Username == username && y.Password == password && y.Role == "Customer");
                int status = db.NGUOIDUNGs.Count(z => z.Username == username && z.Password == password && z.Status == "true");
                if (role == 0)
                {
                    return -1;                   
                }
                else if (status == 0)
                {
                    return -2;
                }
                else{
                    return 0;
                }
            }
            else
            {
                 return -3;
            }
        }
        public bool CheckUserName(string Username)
        {
            return db.NGUOIDUNGs.Count(x => x.Username == Username) > 0;
        }
        public bool CheckEmail(string Email)
        {
            return db.NGUOIDUNGs.Count(x => x.Email == Email) > 0;
        }
        public int Insert(NGUOIDUNG entity)
        {
            db.NGUOIDUNGs.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }
        public IEnumerable<NGUOIDUNG> ListALL(int page, int pageSize)
        {
            return db.NGUOIDUNGs.OrderByDescending(x => x.Id).Where(x => x.Status == "false").ToPagedList(page, pageSize);
        }
        public bool UpdateStatus(string status, int id)
        {
            var order = db.NGUOIDUNGs.Find(id);
            order.Status = status;
            db.SaveChanges();
            return true;
        }
    }
}
