using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BlogRepository : IBlogDal
    {
        public void Add(Blog item)
        {
            using var myContext = new MyContext();
            myContext.Add(item);
            myContext.SaveChanges();
        }

        public void Delete(Blog item)
        {
            using var myContext = new MyContext();
            myContext.Remove(item);
            myContext.SaveChanges();
        }

        public List<Blog> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            using var myContext = new MyContext();
            return myContext.Blogs.Find(id);
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAll()
        {
            using var myContext = new MyContext();
            return myContext.Blogs.ToList();
        }

        public void Update(Blog item)
        {
            using var myContext = new MyContext();
            myContext.Update(item);
            myContext.SaveChanges();
        }
    }
}
