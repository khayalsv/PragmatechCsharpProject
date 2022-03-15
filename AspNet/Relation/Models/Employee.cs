using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
    }
}
