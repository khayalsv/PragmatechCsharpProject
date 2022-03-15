using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Hobby
    {
        public int HobbyID { get; set; }
        public string HobbyName { get; set; }

        public ICollection<TeacherToHobby> collectionTable { get; set; }

    }
}
