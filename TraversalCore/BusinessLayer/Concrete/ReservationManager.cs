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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListAllWithManager(int id)
        {
            return _reservationDal.GetListAllWithInclude(id);
        }

        public List<Reservation> GetListByApprovalManager(int id)
        {
            return _reservationDal.GetListByApproval(id);
        }

        public List<Reservation> GetListByCurrentManager(int id)
        {
            return _reservationDal.GetListByCurrentReservation(id);
        }

        public List<Reservation> GetListByOldManager(int id)
        {
            return _reservationDal.GetListByOldReservation(id);

        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
