using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListWithInclude(int id)
        {
            Context c = new Context();
            return c.Comments.Include(x => x.AppUser).Include(x => x.Destination).Where(x=>x.DestinationId == id).ToList();
        }

        public List<Comment> GetListWithInclude()
        {
            Context c = new Context();
            return c.Comments.Include(x => x.AppUser).Include(x => x.Destination).ToList();
        }

        public List<Comment> GetListWithInclude2(int id)
        {
            Context c = new Context();
            return c.Comments.Include(x => x.AppUser).Include(x => x.Destination).Where(x => x.DestinationId == id).ToList();
        }
    }
}
