using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class TeacherToHobby
    {
        public int TeacherID { get; set; }
        public int HobbyID { get; set; }


        public virtual Teacher TeacherTable { get; set; }
        public virtual Hobby HobbyTable { get; set; }

    }
}
