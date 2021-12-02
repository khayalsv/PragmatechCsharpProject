using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i = 0; i <=10; i+=2)
			{
                Console.WriteLine(i);
			}
        }

        public class Car : Vehicle
        {
            public double FuelCapacity { get; set; }
            public double FuelFor1km { get; set; }

            private double _currentFuel;
            public double CurrentFuel
            {
                get { return _currentFuel; }
                set
                {
                    if (value < this.FuelCapacity)
                    {
                        _currentFuel = value;
                    }
                    else
                    {
                        Console.WriteLine("Benzin tutumunnan cox ola bilmez");
                    }
                }
            }

            public override void Drive(double km)
            {
                if (this.CurrentFuel >= km * this.FuelFor1km)
                {
                    this.millage += km;
                    this.CurrentFuel -= km * this.FuelFor1km;
                    Console.WriteLine("Gedildi");
                }
                else
                {
                    Console.WriteLine("Bu benzinle bu mesafe gedile bilmez");
                }
            }
        }

        public class Bycle : Vehicle
        {
            public override void Drive(double km)
            {
                this.millage += km;
            }
        }
    }
}