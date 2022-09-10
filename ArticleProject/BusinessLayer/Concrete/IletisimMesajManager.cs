using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class IletisimMesajManager:IiletisimMesajService
    {
        IIletisimMesajDal _iletisimMesaj;

        public IletisimMesajManager(IIletisimMesajDal iletisimMesaj)
        {
            _iletisimMesaj = iletisimMesaj;
        }

        public List<IletisimMesajUye> GetList()
        {
            return _iletisimMesaj.GetListAll();
        }

        public void TAdd(IletisimMesajUye t)
        {
            _iletisimMesaj.Insert(t);
        }

        public void TDelete(IletisimMesajUye t)
        {
            _iletisimMesaj.Delete(t);
        }

        public IletisimMesajUye TGetById(int id)
        {
            return _iletisimMesaj.GetById(id);
        }

        public void TUpdate(IletisimMesajUye t)
        {
            _iletisimMesaj.Update(t);
        }
    }
}
