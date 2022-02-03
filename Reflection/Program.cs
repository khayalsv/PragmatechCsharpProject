using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////Obyetk yaradilsa///////////////

            //Student st = new Student();
            //st.Name = "Khayal";
            //st.Age = 22;

            //var type = st.GetType();

            //foreach (PropertyInfo item in type.GetProperties())
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (MethodInfo item in type.GetMethods())
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (MemberInfo item in type.GetMembers())
            //{
            //    Console.WriteLine(item);
            //}

            ///////////abstrac (obyekti yaranmir)/////////////
            
            var typeClass = typeof(Student);
            foreach (MemberInfo item in typeClass.GetMembers())
            {
                Console.WriteLine(item);
            }
        }
    }


    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public void GetStudent()
        {

        }

    }
}
