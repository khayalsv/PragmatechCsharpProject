using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("e: ");
            int j = Convert.ToInt32(Console.ReadLine());
            NumericalAverage(x, y, z, k, j);


        }
        public static void NumericalAverage(int a, int b, int c, int d, int e)
        {
            int f = (a + b + c + d + e) / 5;
            Console.WriteLine($"({a}+{b}+{c}+{d}+{e})/5 = {f}");
        }
    }
}
