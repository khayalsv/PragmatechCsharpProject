using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriteService
    {
        void Add(Writer item);
        void Delete(Writer item);
        void Update(Writer item);
        List<Writer> GetAllList();
        Writer GetById(int id);
        List<Writer> GetBlogListWithCategory();
    }
}
