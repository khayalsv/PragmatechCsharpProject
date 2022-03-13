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

        public IList<TeacherToHobby> collectionTable { get; set; }

    }
}
