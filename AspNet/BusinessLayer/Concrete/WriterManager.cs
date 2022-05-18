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
    public class WriterManager : IWriteService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer item)
        {
            _writerDal.Insert(item);
        }

        public void Delete(Writer item)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetBlogListWithCategory()
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer item)
        {
            throw new NotImplementedException();
        }
    }
}
