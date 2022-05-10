
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvernote.DataAccessLayer
{
    public class BaseEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}

