using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void Add(Comment item);
       // void Delete(Comment item);
       // void Update(Comment item);
        List<Comment> GetAllList(int id);
       // Comment GetById(int id);
    }
}
