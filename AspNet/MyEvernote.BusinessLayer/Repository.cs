using Microsoft.EntityFrameworkCore;
using MyEvernote.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.BusinessLayer
{
    public class Repository<T> where T:class
    {
        private MyContext _myContext;
        private DbSet<T> _objectSet;
        public Repository()
        {
            _myContext = RepositoryBase.CreateContext();

            _objectSet = _myContext.Set<T>();
        }

        public List<T> List() 
        {
            return _objectSet.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

        //public IQueryable<T> List(Expression<Func<T, bool>> where)
        //{
        //    return _objectSet.Where(where);
        //}

        public int Inset(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int Update(T obj)
        {
           return Save();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public int Save()
        {
            return _myContext.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }
    }
}
