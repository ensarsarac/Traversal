using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal: IGenericDal<Reservation>
    {
        public List<Reservation> GetListByApproval(int id);
        public List<Reservation> GetListByOldReservation(int id);
        public List<Reservation> GetListByCurrentReservation(int id);
        public List<Reservation> GetListAllWithInclude(int id);
    }
}
