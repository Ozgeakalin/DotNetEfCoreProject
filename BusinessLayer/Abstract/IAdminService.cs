using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetAll();
        Admin AuthAdmin(Admin admin);
        Admin Add(Admin admin);
        Admin Update(Admin admin);
        void Delete(Admin admin);
    }
}
