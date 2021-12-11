using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Bakery", 20, 3);
            product.GetTotalPrice();
            Console.WriteLine(product.Code);
            Console.WriteLine(product.TotalPrice);
            Product milk = new Product("Milk", 100, 3);
            milk.GetTotalPrice();
            Console.WriteLine(milk.Code);
            Console.WriteLine(milk.TotalPrice);

        }
    }
    class Product
    {
        public string Name;
        public double Price;
        public double DiscountPrice;
        public string Code;
        public static int No = 1000;
        public double TotalPrice;
        public Product(string name, double price, double discountPrice)
        {
            Name = name;
            Price = price;
            DiscountPrice = discountPrice;
            string x = name.Substring(0, 1);
            No++;
            Code = x + No;

        }
        public double GetTotalPrice()
        {
            double y = (this.Price * this.DiscountPrice) / 100;
            this.TotalPrice = Price - y;
            return TotalPrice;
        }

    }
}
