using Microsoft.EntityFrameworkCore;
using MyEvernote.DataAccessLayer;
using MyEvernote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.BusinessLayer
{
    public class Test
    {        public Test()
        {
            Repository<Category> repository = new Repository<Category>();
            List<Category> categories = repository.List();
        }    }
}
