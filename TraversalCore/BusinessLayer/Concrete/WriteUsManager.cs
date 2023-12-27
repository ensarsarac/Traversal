using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriteUsManager : IWriteUsService
    {
        IWriteUsDal _writeusDal;

        public WriteUsManager(IWriteUsDal writeusDal)
        {
            _writeusDal = writeusDal;
        }

        public void TAdd(WriteUs t)
        {
            _writeusDal.Insert(t);
        }

        public void TDelete(WriteUs t)
        {
            _writeusDal.Delete(t);
        }

        public WriteUs TGetById(int id)
        {
            return _writeusDal.GetById(id);
        }

        public List<WriteUs> TGetList()
        {
            return _writeusDal.GetList();
        }

        public void TUpdate(WriteUs t)
        {
            throw new NotImplementedException();
        }
    }
}
