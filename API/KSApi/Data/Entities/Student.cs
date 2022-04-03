using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSApi.Data.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double? Salary { get; set; }
        public int? Gender { get; set; }
    }
}
