using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User.ShowInfo();        
            User.PasswordChecker();
        }
    }


    abstract class Account
    {
        public virtual void PasswordChecker()
        {
            Console.WriteLine("");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("");
        }
    }


    class User : Account
    {
        public string fullname { get; set; }

        private string _email;
        public string email
        {
            get { return _email; }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEMAIL IS NOT VALID");
                    //throw new ArgumentException("EMAIL IS NOT VALID");
                }
            }

        }
        


        public string password { get; set; }



        public User(string fullname, string email, string password)
        {
            this.fullname = fullname;
            this.email = email;
            this.password = password;
        }
        public static List <User> user = new List<User>();

        public static void ShowInfo()
        {
       

            Console.WriteLine("Fullname daxil edin: ");
            string fullname = Console.ReadLine();

            Console.WriteLine("\nEmail daxil edin: ");
            string email = Console.ReadLine();

            Console.WriteLine("\npassword daxil edin: ");
            string password = Console.ReadLine();

            user.Add(new User(fullname, email, password));

            foreach (var item in user)
            {
                Console.WriteLine($"\nFullName:{item.fullname} email:{item.email} password:{item.password}");
            }

        }

        public static void PasswordChecker()
        {

            foreach (var item in user)
            {
                int minLength = 8;
                bool Uppercase = item.password.Any(char.IsUpper);
                bool Lowercase = item.password.Any(char.IsLower);

                int score = 0;



                if (item.password.Length >= minLength)
                {
                    score++;
                    Console.WriteLine("\nMinimum Length test passed.");
                }
                else
                {
                    Console.WriteLine("\nMinimum Length test failed.");
                }

                if (Uppercase)
                {
                    score++;
                    Console.WriteLine("Uppercase test passed.");
                }
                else
                {
                    Console.WriteLine("Uppercase test failed.");
                }

                if (Lowercase)
                {
                    score++;
                    Console.WriteLine("Lowercase test passed.");
                }
                else
                {
                    Console.WriteLine("Lowercase test failed.");
                }

                if (score == 3)
                {
                    Console.WriteLine("\nTrue");
                }
                else
                {
                    Console.WriteLine("\nFalse");
                }
            }
            

        }
    }
}