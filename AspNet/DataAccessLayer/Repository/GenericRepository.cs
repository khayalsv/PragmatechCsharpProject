using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var myContext = new MyContext();
            myContext.Remove(t);
            myContext.SaveChanges();
        }

        public List<T> GetAllList()
        {
            using var myContext = new MyContext();
            return myContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var myContext = new MyContext();
            return myContext.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var myContext = new MyContext();
            myContext.Add(t);
            myContext.SaveChanges();
        }

        public void Update(T t)
        {
            using var myContext = new MyContext();
            myContext.Update(t);
            myContext.SaveChanges();
        }
    }
}
