using MyEvernote.DataAccessLayer.Repository;
using MyEvernote.Entities;
using System.Threading.Tasks;

namespace MyEvernote.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Category, int> StudentRepository { get; set; }

        private readonly MyContext _mycontext;
        public UnitOfWork(MyContext mycontext)
        {
            _mycontext = mycontext;
            StudentRepository = new EfRepository<, int>(mycontext);
        }

        public async Task Commit()
        {
            await _mycontext.SaveChangesAsync();
        }
    }
}
