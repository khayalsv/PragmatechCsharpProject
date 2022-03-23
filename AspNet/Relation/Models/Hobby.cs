using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Hobby
    {
        public int ID { get; set; }
        public string HobbyName { get; set; }

        public IList<TeacherToHobby> TeacherToHobbies { get; set; }

    }
}
