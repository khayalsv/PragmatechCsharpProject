using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentyRepository : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListWithBlog()
        {
            using (var myContext = new MyContext())
                return myContext.Comments.Include(x => x.Blog).ToList();
        }
    }
}
