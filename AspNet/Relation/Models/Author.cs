using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}
