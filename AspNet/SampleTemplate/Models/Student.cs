using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTemplate.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public virtual StudentAddress Adress { get; set; }
    }
}
