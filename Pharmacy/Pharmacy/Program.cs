using System;
using System.Collections.Generic;

namespace Pharmacy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Medicine> med = new List<Medicine>();
            Medicine derman1 = new Medicine("nemesil",5,20);
            Medicine derman2 = new Medicine("spazmaqon", 3, 15);
            med.Add(derman1);
            med.Add(derman2);

            derman1.Sell(3);
            derman1.Sell(23);
            derman2.Sell(1);


        }
    }


    class Medicine
    {
        public List<Medicine> medicines { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
        public Medicine(string name, int price, int count)
        {


            Count = count;
            Name = name;
            Price = price;

        }

        public void Sell(int buyMedicine)
        {
            
            if (Count >= buyMedicine)
            {
                Count -= buyMedicine;
                int resultPrice = buyMedicine * Price;
                Total += resultPrice;
                Console.WriteLine($" {buyMedicine} eded {Name} satildi ve umumi qiymet {resultPrice} manat, " +
                     $"bazada ise umumi satisdan elde edilen gelir {Total} manat");
            }
            else
            {
                Console.WriteLine($"Bazada {Count} mehsul var, sizin isteyinize uygun deyil");
            }
        }

        public void FindMedicine(string medicineName)
        {
            Medicine info = medicines.Find(n => n.Name.ToLower().Trim() == medicineName.ToLower().Trim());
            if (info != null)
            {
                Console.WriteLine($"Name:{info.Name} \n Price:{info.Price} \n Count:{info.Count} \n" +
                $"Total:{info.Total}");
            }
        }

        public void AddMedicine(Medicine medicine)
        {
            medicines.Add(medicine);
        }
    }



}
