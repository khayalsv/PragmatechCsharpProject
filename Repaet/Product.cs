using System;

namespace RepaetProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milla = new Milk();
            milla.Price = 1.5;
            milla.Count = 5;
            milla.Sell(3);
            milla.Sell(1);
        }

        abstract class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Count { get; set; }
            public double Total { get; set; }

            public void Sell(int buyProduct)
            {
                if (Count>=buyProduct)
                {
                    double result = buyProduct * Price;
                    Total += result;
                    Console.WriteLine($"{buyProduct} satilldi , umumi qiymet {result}, umumi gelir {Total}");
                }
                else
                {
                    Console.WriteLine($"{buyProduct} bu qeder mal yoxdu");
                }
            }
        }
        
        class Milk : Product
        {

            public double Volume { get; set; }
            public double Fatrate { get; set; }
        }
    }
}
