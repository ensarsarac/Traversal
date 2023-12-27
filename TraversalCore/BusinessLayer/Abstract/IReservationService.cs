using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService: IGenericService<Reservation>
    {
        public List<Reservation> GetListByApprovalManager(int id);
        public List<Reservation> GetListByOldManager(int id);
        public List<Reservation> GetListByCurrentManager(int id);
        public List<Reservation> GetListAllWithManager(int id);

    }
}
