using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void Add(Blog item);
        void Delete(Blog item);
        void Update(Blog item);
        List<Blog> GetAllList();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
    }
}
