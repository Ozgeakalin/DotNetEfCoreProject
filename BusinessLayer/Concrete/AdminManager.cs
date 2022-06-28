using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public Admin Add(Admin admin)
        {
          return  _adminDal.Add(admin);
        }

        public void Delete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public Admin AuthAdmin(Admin admin)
        {
            return _adminDal.GetAll(x => x.KullaniciAdi == admin.KullaniciAdi && x.Sifre == admin.Sifre).FirstOrDefault();
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public Admin Update(Admin admin)
        {
            return _adminDal.Update(admin);
        }
    }
}
