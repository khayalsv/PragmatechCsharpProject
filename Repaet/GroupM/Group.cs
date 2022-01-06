using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaett
{
    public class Group
    {
        public static List<Student> room = new List<Student>();
        public string groupName { get; set; }
        //public int Capacity { get; set; }
        public int No { get; set; }
        public static int id=100;

        public Group(string name/*,int capacity*/)
        {
            groupName = name;
            //Capacity = capacity;
            No = ++id;
            
        }

        public static void AddStudent(string name,string surname)
        {
            room.Add(new Student(name,surname));
        }

    }

}
