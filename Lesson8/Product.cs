using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {

            Milk milla = new Milk()
            {
                price = 4,
                count = 60,
                volume = 3,
                fatrate = 2
            };
            milla.Sell(3);
            milla.Sell(4);
            milla.Sell(30);
        }
    }

    public abstract class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int count { get; set; }
        public int totalincome { get; set; }

        public void Sell(int buyProduct)
        {
            if (count>=buyProduct)
            {
                count -= buyProduct;
                int resultPrice = buyProduct * price;
                totalincome += resultPrice;
                Console.WriteLine($"{buyProduct} mehsul satildi ve umumi qiymet{resultPrice} manat, " +
                     $"bazada ise umumi satisdan elde edilen gelir{totalincome} manat");
            }
            else
            {
             Console.WriteLine($"Bazada {count} mehsul var, sizin isteyinize uygun deyil");
            }
        }
    }

    public class Milk : Product
    {
        public int volume { get; set; }
        public int fatrate { get; set; }
    }

}
