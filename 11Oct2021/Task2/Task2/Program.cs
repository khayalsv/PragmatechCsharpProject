using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Action to");
            Console.WriteLine("1 for Area");
            Console.WriteLine("2 for Perimetr");

            int action = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = 0;

            switch (action)
            {
                case 1:
                    {
                        c = Area(a, b);
                        break;
                    }

                case 2:
                    {
                        c = Perimetr(a, b);
                        break;
                    }


                default:
                    break;
            }
            Console.WriteLine(c);

        }
        public static int Area(int a, int b)
        {
            int c = a * b;
            return c;
        }
        public static int Perimetr(int a, int b)
        {
            int c = (a + b) * 2;
            return c;
        }
    }
}
