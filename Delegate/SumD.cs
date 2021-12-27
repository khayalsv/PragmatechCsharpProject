using System;

namespace SumDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> check = delegate (int a)
              {
                  Action<int> num = Positive;
                  num += Divisible;
                  num += Even;
                  num.Invoke(a);
              };

            check.Invoke(25);
        }
        public static void Positive(int a) => Console.WriteLine(a > 0 ? "Positive" : "Negative");

        public static void Divisible(int a) => Console.WriteLine(a % 5==0 ? "Divisible" : "Not Divisible");

        public static void Even(int a) => Console.WriteLine(a % 2==0 ? "even" : "odd");
    }  
}
