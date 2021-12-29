using System;
using System.Collections.Generic;

namespace Repaett
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Queue
            //Queue<string> names = new Queue<string>();
            //Console.WriteLine("please enter the name");

            //for (int i = 0; i < 6; i++)
            //{
            //    string name = Console.ReadLine();

            //    if (names.Count < 5)
            //    {
            //        names.Enqueue(name);

            //    }
            //    else
            //    {
            //        names.Dequeue();

            //    }
            //}

            //Console.WriteLine("Result");
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Change numbers
            //List<int> numbers = new List<int>();
            //List<int> newnumbers1 = new List<int>();
            //List<int> newnumbers2 = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"please enter the number {i+1/10}");
            //    int number = Int32.Parse(Console.ReadLine());

            //    numbers.Add(number);
            //}

            //Console.WriteLine("Change number");
            //for (int i = 5; i < numbers.Count; i++)
            //{
            //    newnumbers1.Add(numbers[i]);
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    newnumbers2.Add(numbers[i]);
            //}
            //newnumbers1.AddRange(newnumbers2);
            //newnumbers1.ForEach(Console.WriteLine);
            //Console.WriteLine("Changed");
            #endregion

            #region Sequence
            SortedSet<int> sort = new SortedSet<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"please enter the number {i + 1 / 3}");
                int number = Int32.Parse(Console.ReadLine());

                sort.Add(number);
            }
            Console.WriteLine("Added numbers");
            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

    }
}
