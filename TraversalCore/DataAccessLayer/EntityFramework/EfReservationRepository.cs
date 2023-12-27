using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationRepository : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListByOldReservation(int id)
        {
            Context c = new Context();
            return c.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == id && x.Status=="Geçmiş Rezervasyon").ToList();
        }

        public List<Reservation> GetListByApproval(int id)
        {
            Context c = new Context();
            return c.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == id).Where(y=>y.Status=="Onay Bekliyor").ToList();
        }

        public List<Reservation> GetListByCurrentReservation(int id)
        {
            Context c = new Context();
            return c.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == id && x.Status == "Onaylandı").ToList();
        }

        public List<Reservation> GetListAllWithInclude(int id)
        {
            Context c = new Context();
            return c.Reservations.Include(x => x.AppUser).Include(x => x.Destination).Where(x => x.AppUserId == id).ToList();
        }
    }
}
