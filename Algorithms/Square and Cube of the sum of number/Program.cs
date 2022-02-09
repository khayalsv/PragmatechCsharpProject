using System;

namespace Square_and_Cube_of_the_sum_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number: ");
            int a= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            int b = Int32.Parse(Console.ReadLine());

            //Total
            int total = a + b;

            //Square
            int square = total * total;

            //Cube
            int cube = square * total;

            Console.WriteLine("Total: " + total);

            Console.WriteLine("Square: " + square);

            Console.WriteLine("Cube: " + cube);
        }
    }
}
