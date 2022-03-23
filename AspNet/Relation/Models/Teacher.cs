using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string TeacherName { get; set; }
        [NotMapped]
        public List<int> HobbyID { get; set; }
        public IList<TeacherToHobby> TeacherToHobbies { get; set; }
    }
}
