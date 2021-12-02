using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine medicine = new Medicine()
            {
                name = "nemesil",
                price = 4,
                count = 60,

            };
           
            medicine.Sell(3);
            medicine.Sell(4);
            medicine.Sell(30);

        }
    }

    class Medicine
    {
        List<Medicine> list = new List<Medicine>();
        public string name { get; set; }
        public int price { get; set; }
        public int totalincome { get; set; }
        public int count { get; set; }
        public static int no { get; set; }

    
        public void Sell(int buyProduct)
        {
            if (count >= buyProduct)
            {
                count -= buyProduct;
                int resultPrice = buyProduct * price;
                totalincome += resultPrice;
                Console.WriteLine($" {buyProduct} eded {name} satildi ve umumi qiymet {resultPrice} manat, " +
                     $"bazada ise umumi satisdan elde edilen gelir {totalincome} manat");
            }
            else
            {
                Console.WriteLine($"Bazada {count} mehsul var, sizin isteyinize uygun deyil");
            }
        }
        public void AddMedicine()
        {
            
        }

        public void FindMedicine(string name)
        {
            foreach (var item in list)
            {
                if (item.name == name)
                {
                    Console.WriteLine(item.name + " " + item.count);
                }
            }
        }
    }
}

