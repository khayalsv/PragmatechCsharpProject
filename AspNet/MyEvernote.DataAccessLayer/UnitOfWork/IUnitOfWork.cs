
using MyEvernote.DataAccessLayer.Repository;
using MyEvernote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvernote.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<Category, int> Repository { get; set; }
        public Task Commit();
    }
}
