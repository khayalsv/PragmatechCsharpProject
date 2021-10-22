using System;
using System.Linq;


namespace Task
{
    class Account
    {
        public string username;
        public string password;
        public int no;
        static int code;

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
            no = ++code;
        }

        public static int IsPassWordvalid(string password)
        {
            int minLength = 8;
            int maxLength = 25;

            

            bool Uppercase = password.Any(char.IsUpper);
            bool Lowercase = password.Any(char.IsLower);
            bool SpecialChar = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool Digit = password.Any(char.IsDigit);

            int score = 0;

            if (password.Length >= minLength && maxLength >= password.Length)
            {
                score++;
                Console.WriteLine("Minimum Length test passed.");
            }
            else
            {
                Console.WriteLine("Minimum Length test failed.");
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

            if (Digit)
            {
                score++;
                Console.WriteLine("Digits test passed.");
            }
            else
            {
                Console.WriteLine("Digits test failed.");
            }

            if (SpecialChar)
            {
                score++;
                Console.WriteLine("Special Characters test passed.");
            }
            else
            {
                Console.WriteLine("Special Characters test failed.");
            }

            return score;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Username: ");
            string username=Console.ReadLine();

            
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();


            static bool IsUserNameValid(string str)
            {
                {
                    foreach (char c in str)
                    {
                        if (!Char.IsLetterOrDigit(c))
                            return false;
                    }
                    return true;
                }
            }

            if (IsPassWordvalid(password)==5 && IsUserNameValid(username))
            {
                Account account = new Account(username, password);
                Console.WriteLine($"{account.no},{ account.username},{ account.password}");
            }
            else
            {
                Console.WriteLine("Error");
            }
            
            static int IsPassWordvalid(string password)
            {
                int minLength = 8;
                int maxLength = 25;



                bool Uppercase = password.Any(char.IsUpper);
                bool Lowercase = password.Any(char.IsLower);
                bool SpecialChar = password.Any(ch => !Char.IsLetterOrDigit(ch));
                bool Digit = password.Any(char.IsDigit);

                int score = 0;

                if (password.Length >= minLength && maxLength >= password.Length)
                {
                    score++;
                    Console.WriteLine("Minimum Length test passed.");
                }
                else
                {
                    Console.WriteLine("Minimum Length test failed.");
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

                if (Digit)
                {
                    score++;
                    Console.WriteLine("Digits test passed.");
                }
                else
                {
                    Console.WriteLine("Digits test failed.");
                }

                if (SpecialChar)
                {
                    score++;
                    Console.WriteLine("Special Characters test passed.");
                }
                else
                {
                    Console.WriteLine("Special Characters test failed.");
                }

                return score;
            }
        }
    }

}
