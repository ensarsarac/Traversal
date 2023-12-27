using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T:class 
    {

        IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public void TAdd(T t)
        {
            _genericDal.Insert(t);
        }

        public void TDelete(T t)
        {
            throw new NotImplementedException();
        }

        public T TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(T t)
        {
            throw new NotImplementedException();
        }
    }
}
