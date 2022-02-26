using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StudentID { get; set; }
        public virtual Student Students { get; set; }
    }
}
