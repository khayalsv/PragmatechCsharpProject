using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            MultipleTable(z);
        }
        public static void MultipleTable(int x)
        {
            for (int i = 0; i <= 10; i++)
            {             
                int y = i * x;
                Console.WriteLine($"{i}*{x}={y}");

            }
        }


    }
}


