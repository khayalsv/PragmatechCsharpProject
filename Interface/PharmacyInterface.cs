using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine medicine1 = new Medicine
            {
                name = "nemesil",
                price = 4,
                count = 60,
            };
            Medicine medicine2 = new Medicine
            {
                name = "spazmaqon",
                price = 2,
                count = 45,
            };

            Pharmacy pharmacy = new Pharmacy();
            pharmacy.AddMedicine(medicine1);
            pharmacy.AddMedicine(medicine2);

            medicine1.Sell(20);
            pharmacy.FindMedicine("nemesil");
            Console.WriteLine(medicine2.name);

        }
    }

    class Pharmacy : IPharmacy
    {
        public List<Medicine> medicines { get ; set; }

        public Pharmacy()
        {
            this.medicines = new List<Medicine>();
        }

        public void AddMedicine(Medicine medicine)
        {
            bool existName = false;

            foreach (var item in medicines)
            {
                if (item.name.ToLower().Trim() == medicine.name.ToLower().Trim())
                {
                    existName = true;
                    break;

                }
            }
            if (!existName)
            {
                medicines.Add(medicine);
            }
        }

        public void FindMedicine(string medicineName)
        {
            Medicine info = medicines.Find(n => n.name.ToLower().Trim() == medicineName.ToLower().Trim());
            if (info != null)
            {
                Console.WriteLine($"Name:{info.name} \n Price:{info.price} \n Count:{info.count} \n" +
                $"Total:{info.totalincome}");
            }
        }

        
    }

    class Medicine
    {        
        public string name { get; set; }
        public int price { get; set; }
        public int count { get; set; }
        public int totalincome { get; set; }

        public void Sell(int buyMedicine)
        {
            if (count >= buyMedicine)
            {
                count -= buyMedicine;
                int resultPrice = buyMedicine * price;
                totalincome += resultPrice;
                Console.WriteLine($" {buyMedicine} eded {name} satildi ve umumi qiymet {resultPrice} manat, " +
                     $"bazada ise umumi satisdan elde edilen gelir {totalincome} manat");
            }
            else
            {
                Console.WriteLine($"Bazada {count} mehsul var, sizin isteyinize uygun deyil");
            }
        }

    }


    interface IPharmacy
    {
        public List<Medicine> medicines { get; set; }
        public void AddMedicine(Medicine medicine);
        public void FindMedicine(string name);

    }


}