using MyEvernote.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.BusinessLayer
{
    public class RepositoryBase
    {
        private static MyContext _myContext;

        protected RepositoryBase()
        {
            RepositoryBase.CreateContext();
        }

        public static MyContext CreateContext()
        {
            if (_myContext==null)
            {
                _myContext = new MyContext();
            }

            return _myContext;
        }

    }
}
