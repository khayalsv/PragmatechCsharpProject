using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTemplate.Models
{
    public class StudentAddress
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
