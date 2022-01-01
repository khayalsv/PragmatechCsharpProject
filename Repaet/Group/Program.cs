using System;
using System.Collections.Generic;

namespace Repaett
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Group> groups = new List<Group>();
            List<Student> room = new List<Student>();

            Group group1 = new Group("208a1");
            Group group2 = new Group("303b5");

            Student s1 = new Student("Xeyal", "Selimov");
            Student s2 = new Student("Sadiq", "Ilyasli");
            Student s3 = new Student("Nurlan", "Hesenli");
            Student s4 = new Student("Rasim", "Eliyev");


            room.Add(s1);
            room.Add(s2);
            room.Add(s3);
            room.Add(s4);

            group1.AddStudent(s1);
            group1.AddStudent(s2);

            group2.AddStudent(s3);
            group2.AddStudent(s4);

            groups.Add(group1);
            groups.Add(group2);

            foreach (var item in room)
            {
                Console.WriteLine(item.name+item.surname);
            }

            foreach (var item in groups)
            {
                Console.WriteLine($"{item.name}");
            }

        }


    }
}
