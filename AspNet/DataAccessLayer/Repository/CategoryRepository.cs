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
    public class CategoryRepository : ICategoryDal
    {
        MyContext myContext = new MyContext();
        public void Add(Category item)
        {
            myContext.Add(item);
            myContext.SaveChanges();
        }

        public void Delete(Category item)
        {
            myContext.Remove(item);
            myContext.SaveChanges();
        }

        public List<Category> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return myContext.Categories.Find(id);
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAll()
        {
            return myContext.Categories.ToList();
        }

        public void Update(Category item)
        {
            myContext.Update(item);
            myContext.SaveChanges();
        }
    }
}
