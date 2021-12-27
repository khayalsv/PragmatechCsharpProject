using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(IsEven,3,5,6,7,8));
            Console.WriteLine(Sum(IsDivisibleByThree, 3, 5, 6, 7, 8));
        }


        public delegate bool Checkers(int x);
        static bool IsEven(int a) => a % 2 == 0;
        static bool IsDivisibleByThree(int a) => a % 3 == 0;  


        static int Sum(Checkers call , params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (call(item))
                {
                    sum += item;
                }

            }
            return sum;
        }
    }
}
