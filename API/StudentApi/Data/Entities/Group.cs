using System.Collections.Generic;

namespace BeginProject.Data.Entities
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public ICollection<Student> Students { get; set; } //One to Many Group->Students

    }

}
