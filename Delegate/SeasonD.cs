using System;
using System.Text;

namespace DelegateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Choose choose = ChooseMethod;
            Console.WriteLine("Methods \n 1.Ayin adini yazdirmaq \n 2.Feslin adini yazdirmaq");
            Console.WriteLine("Bir metod seçin");
            string method = Console.ReadLine();
            Console.WriteLine("Bir ay secin");
            byte month = byte.Parse(Console.ReadLine());
            Console.WriteLine(choose.Invoke(method,month));
        }

        public delegate string Print(byte Month);
        public delegate string Choose(string method,byte month);

        public static string ChooseMethod(string method, byte month)
        {
            Print print = null;
            if (method=="1")
            {
                PrintInfo("Daxil edilen reqeme uygun ay gosteren proqram");
                print = MonthName;
            }
            else if (method=="2")
            {
                PrintInfo("Daxil edilen reqeme uygun fesli gosteren proqram");
                print = PrintSeason;     
            }
            return print(month);
        }
        public static void PrintInfo(string info)
        {
            Console.WriteLine(info);
        }

        public static string MonthName(byte Month)
        {
            string month;
            switch (Month)
            {
                case 1:
                    month = "Yanvar";
                    break;
                case 2:
                    month = "Fevral";
                    break;
                case 3:
                    month = "Mart";
                    break;
                default:
                    month = "Bele bir ay yoxdu";
                    break;
            }
            return month;
        }
        public static string PrintSeason(byte Month)
        {
            string season;

            switch (Month)
            {
                case 1:
                case 2:
                    season = "Qis fesli";
                    break;
                case 3:
                    season = "Yaz fesli";
                    break;
                default:
                    season = "Bele bir ay yoxdu";
                    break;
            }
            return season;
        }
    }    
}
