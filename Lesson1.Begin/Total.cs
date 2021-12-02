using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");

            int z = Convert.ToInt32(Console.ReadLine());
            Number(z);

        }
        public static void Number(int x)
        {
            int total= 0;
            int multiple = 1;
            for (int i = 1; i <= x; i++)  
            {
                total += i;
                multiple *= i;
                Console.WriteLine($"total: {total} ");
                Console.WriteLine($"multiple: {multiple}");
                Console.WriteLine($"multiple-total = {multiple-total}");
            }         
        }
    }
 
}
