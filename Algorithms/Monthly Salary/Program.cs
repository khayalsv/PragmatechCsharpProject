using System;

namespace Monthly_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the Hourly Income");
            //int hourlyincome = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Weekly working hours");
            //int weeklyworkhours = Int32.Parse(Console.ReadLine());

            //int weeklyincome = hourlyincome * weeklyworkhours;

            //int monthlyincome = weeklyincome * 4;

            //Console.WriteLine("Salary: " + monthlyincome);


            //

            Console.WriteLine("Enter the Hourly Income");
            int hourlyincome = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Weekly working hours");
            int dailyworkhours = Int32.Parse(Console.ReadLine());

            int dailyincome = hourlyincome * dailyworkhours;

            int monthlyincome = dailyincome * 30;

            Console.WriteLine("Salary: " + monthlyincome);


        }
    }
}
