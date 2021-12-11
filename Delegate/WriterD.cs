using System;

namespace WriterDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer(WriterEven);


            writer += WriterDivisible; 


            //anonim method
            writer += delegate (int n) 
            {
                Console.WriteLine($"Number {n} is {(n % 4 == 0 ? "divisible by 4" : "not divisible")}");
            };

            //lambda exp
            writer = n =>
            {
                Console.WriteLine($"Number {n} is {(n % 5 == 0 ? "divisible by 5" : "not divisible")}");
            };

            writer.Invoke(20);


        } 

        public delegate void Writer(int n);

        static void WriterEven(int n)
        {
            Console.WriteLine($"Number {n} is {(n%2==0? "even" : "odd")}");
        }

        static void WriterDivisible(int n)
        {
            Console.WriteLine($"Number {n} is {(n % 3 == 0 ? "divisible by 3" : "not divisible")}");
        }


    }
}
