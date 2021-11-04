using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.ShowInfo();          
        }
    }

    abstract class Account
    {
        //public string name { get; set; }

        //public Account(string name)
        //{
        //    this.name = name;
        //}

        //public abstract void PasswordChecker();
        public virtual void ShowInfo()
        {
            Console.WriteLine("showinfo");
        }

    }

    class User : Account
    {
        

        public string fullname;
        public string email;
        public string password;

        //public User(string fullname, string email, string password)
        //{
        //    this.fullname = fullname;
        //    this.email = email;
        //    this.password = password;
        //}


        public override void ShowInfo()
        {
            //List<User> user = new List<User>();

            Console.WriteLine("Fullname daxil edin: ");
            string fullname = Console.ReadLine();

            Console.WriteLine("Email daxil edin: ");
            string email = Console.ReadLine();

            Console.WriteLine("password daxil edin: ");
            string password = Console.ReadLine();

           
            Console.WriteLine($"ad:{fullname} email:{email} password:{password}");

        }
    }
}
