using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForm
{
    public class Genre
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private static int id = 0;
        public Genre()
        {
            Id = ++id;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
