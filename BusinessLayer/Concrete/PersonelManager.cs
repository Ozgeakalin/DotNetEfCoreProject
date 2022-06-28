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
    public class PersonelManager : IPersonelService
    {
        private IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public Personel Add(Personel personel)
        {
            return _personelDal.Add(personel);
        }

        public void Delete(Personel personel)
        {
            _personelDal.Delete(personel);
        }

        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }

        public List<Personel> GetAllByBirim(int birimId)
        {
            return _personelDal.GetAll(x => x.BirimId == birimId);
        }

        public Personel GetPersonelById(int id)
        {
            return _personelDal.Get(x => x.Id == id);
        }

        public Personel Update(Personel personel)
        {
            return _personelDal.Update(personel);
        }
    }
}
