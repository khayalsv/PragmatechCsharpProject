using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>(); 
            dictionary.Add(1, "Khayal");
            dictionary.Add(2, "Sadiq");

            dictionary.ToList().ForEach(x => Console.WriteLine(x.Key+" "+x.Value));

          
        }
    }
}
