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
        List<Comment> GetAllList(int id);
        List<Comment> GetCommentWithBlog();
    }
}
