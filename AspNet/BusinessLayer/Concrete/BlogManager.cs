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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog item)
        {
            _blogDal.Insert(item);
        }

        public void Delete(Blog item)
        {
            _blogDal.Delete(item);
        }

        public List<Blog> GetAllList()
        {
            return _blogDal.GetAllList();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAllList(x => x.Id == id);
        }

        public void Update(Blog item)
        {
            _blogDal.Update(item);
        }
    }
}
