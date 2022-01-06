using System;
using System.Collections.Generic;
using System.Net.Mail;



namespace RepaetAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("xeyal", "saedaema@ilru", "RTdfasafsf");
            user.ShowInfo();



            //List<User> users = new List<User>();
       
            //Console.WriteLine("Fullname daxil edin: ");
            //string fullname = Console.ReadLine();

            //Console.WriteLine("\nEmail daxil edin: ");
            //string email = Console.ReadLine();

            //Console.WriteLine("\npassword daxil edin: ");
            //string password = Console.ReadLine();

            //users.Add(new User(fullname,email,password));

            //Console.WriteLine($"Name: {fullname} Email: {email} Password: {password}");

        }
    }

    abstract class Account
    {
        public abstract bool PasswordChecker(string password);
        public virtual void ShowInfo()
        {
            Console.WriteLine();
        }
    }

    class User : Account
    {
        public string Name { get; set; }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                try
                {
                    MailAddress mailadress = new MailAddress(value);
                    _email = value;
                }
                catch (Exception)
                {
                    
                    Console.WriteLine("Email is not valid");                 
                }
            }
        }

        public string Password { get; set; }

        public User(string name,string email,string password)
        {
            if (PasswordChecker(password)==true)
            {
                Name = name;
                Email = email;
                Password = password;
            }
            else
            {
                Console.WriteLine("Please again enter the password");
            }
        }




        public override bool PasswordChecker(string password)
        {
            if (string.IsNullOrEmpty(password)==true || password.Length < 8 || password.ToLower()==password || password.ToUpper()==password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Email: {Email} Password: {Password}");
        }

    }
}
