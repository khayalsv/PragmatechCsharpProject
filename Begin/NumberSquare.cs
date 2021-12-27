using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int k = Convert.ToInt32(Console.ReadLine());

            NumberSquare(k);
        }
        public static void NumberSquare(int x)
        {
            int y = 1;
            int z = y+x*x;
            Console.WriteLine(z);
        }
    }
}
