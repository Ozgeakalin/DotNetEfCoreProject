using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBirimService
    {
        List<Birim> GetAll();
        Birim GetBirimById(int id);
        Birim Add(Birim birim);
        Birim Update(Birim birim);
        void Delete(Birim birim);
    }
}
