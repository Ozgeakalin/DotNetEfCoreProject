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
    public class BirimManager : IBirimService
    {
        private IBirimDal _birimDal;
        public BirimManager(IBirimDal birimDal)
        {
            _birimDal = birimDal;
        }

        public Birim Add(Birim x)
        {
            return _birimDal.Add(x);
        }

        public void Delete(Birim x)
        {
            _birimDal.Delete(x);
        }

        public List<Birim> GetAll()
        {
            return _birimDal.GetAll();
        }

        public Birim GetBirimById(int id)
        {
            return _birimDal.Get(x => x.Id == id);
        }

        public Birim Update(Birim x)
        {
            return _birimDal.Update(x);
        }
    }
}
