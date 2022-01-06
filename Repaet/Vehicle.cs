using System;

namespace Repaett
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Bmw";
            car.Color = "Blue";
            car.FuelCapacity = 200; //bak tutum
            car.CurrentFuel = 30;  //benzinin miqdari
            car.FuelFor1km = 2; //1 km yandirilan benzin
            car.Drive(10); //nece km gedeceymiz
        }
    }

    abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"color: {Color} brand: {Brand} millage {Millage}");
        }

        public abstract void Drive(double km);
    }

    class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public double FuelFor1km { get; set; }

        private double _currentfuel;
        public double CurrentFuel
        {
            get { return _currentfuel; }
            set
            {
                if (value<this.FuelCapacity)
                {
                    _currentfuel = value;
                }
                else
                {
                    Console.WriteLine("hazirki yanacaq bakin tutumunnan cox ola bilmez");
                }
            }
        }

        public override void Drive(double km)
        {
            if (this.CurrentFuel>=km*this.FuelFor1km)
            {
                this.Millage += km;
                this.CurrentFuel -= km * this.FuelFor1km;
                Console.WriteLine("gedildi");
            }
            else
            {
                Console.WriteLine("bu benzinle gedilmez");
            }
        }
    }
    class Bycle : Vehicle
    {
        public override void Drive(double km)
        {
            this.Millage += km;
        }
    }
}
