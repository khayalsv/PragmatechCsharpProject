using System;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Action
            //Action<string, int> action = delegate (string name, int age)
            //{
            //    Console.WriteLine($"name:{name}, age:{age}");
            //};

            ////anonim
            //action += (n, a) =>
            //{
            //    Console.WriteLine($"new word {n},new number {a}");
            //};

            //action.Invoke("Khayal", 21);
            #endregion


            //Function
            Func<Person, bool> check = CheckFrom;

            check += delegate (Person p) { return p.name.Length > 2; }; //anonim

            check += p => p.email.Contains("@"); //lambda

            Person person = new Person
            {
                name = "Khayal",
                email = "khayal@gmail.com",
                country = "Azerbaijann"
            };

            Console.WriteLine(check(person));


        }

        static bool CheckFrom(Person p) { return p.country == "Azerbaijan"; }

        class Person
        {
            public string name { get; set; }
            public string email { get; set; }
            public string country { get; set; }
        }
    }
}
