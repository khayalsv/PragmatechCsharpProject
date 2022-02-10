using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Buy egg: ");
            //int egg = Int32.Parse(Console.ReadLine());

            //int pay = egg * 1;

            //int healthy = egg - 5;

            //int sell = healthy * 3;

            //int gain = sell - pay;

            //Console.WriteLine("Gain " + gain);





            Console.WriteLine("Price: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Simit: ");
            int y = Int32.Parse(Console.ReadLine());

            int pay = x * y;
            Console.WriteLine("Pay: " + pay);

            Console.WriteLine("Eaten Simit: ");
            int k = Int32.Parse(Console.ReadLine());

            int remain = y - k;

            int increasing = x + 1;

            int sale = remain * increasing;

            Console.WriteLine("Sale: " + sale);

            int gain = sale - pay;

            Console.WriteLine("Gain: " + gain);
           
            



        }
    }
}
