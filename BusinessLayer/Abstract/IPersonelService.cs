using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        List<Personel> GetAllByBirim(int birimId);
        Personel GetPersonelById(int id);
        Personel Add(Personel personel);
        Personel Update(Personel personel);
        void Delete(Personel personel);

    }
}
