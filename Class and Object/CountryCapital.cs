using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countryCapital = new Dictionary<string, string>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"olke daxdil edin: {i+1/3} ");
                string country = Console.ReadLine();
                Console.WriteLine("paytaxt daxil edin");
                string capital = Console.ReadLine();
                countryCapital.Add(country, capital);
            }
            Console.WriteLine("paytaxt adlari liste elave edildi");

            Console.WriteLine("sistemdekiler gormek ucun all yazn");
            string search = Console.ReadLine();
            if (search.ToLower().Trim() == "all")
            {
                Console.WriteLine("sistemde olan olke ve paytaxtlar");
                foreach (KeyValuePair<string,string> item in countryCapital)
                {
                    Console.WriteLine($"{item.Key}, {item.Value}");
                }
            }
            else if (search!="all")
            {
                Console.WriteLine(countryCapital.ContainsKey(search));
            }
        }
    }  
}


