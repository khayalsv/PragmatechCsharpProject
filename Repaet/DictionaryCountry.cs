using System;
using System.Collections.Generic;

namespace REPEAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> world = new Dictionary<string, string>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please enter the country:");
                string country = Console.ReadLine();

                Console.WriteLine("Please enter the capital:");
                string capital= Console.ReadLine();

                world.Add(country, capital);
            }
            Console.WriteLine("Country added");

            Console.WriteLine("By typing the ALL, the countries emerge.");
            string search = Console.ReadLine();
            if (search.Trim().ToLower()=="all")
            {
                foreach (var item in world)
                {
                    Console.WriteLine($"{item.Key} {item.Value}");
                }
            }
            else if (search != "all")
            {
                Console.WriteLine(world.ContainsKey(search));
            }

        }
    }
}
