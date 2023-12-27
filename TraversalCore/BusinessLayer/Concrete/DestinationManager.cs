﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public Destination TGetByIdWithInclude(int id)
        {
            return _destinationDal.GetByIdWithInclude(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public List<Destination> TGetListWithInclude()
        {
            return _destinationDal.GetListWithInclude();
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
