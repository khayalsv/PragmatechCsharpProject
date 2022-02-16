using System;

namespace _4angles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Width: ");
            int width=int.Parse(Console.ReadLine());

            Console.WriteLine("Height: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
