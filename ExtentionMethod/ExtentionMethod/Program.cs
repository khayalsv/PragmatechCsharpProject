using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtensionMethod check = IsOdd;
            check += IsEven;

            Console.WriteLine(check.Invoke(20));
            
        }

        public delegate bool ExtensionMethod(int n);

        static void IsOdd(int n) => Console.WriteLine(n%2==1 ? "odd" : "even");;

        


    }


}
