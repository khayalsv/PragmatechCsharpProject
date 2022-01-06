using System;

namespace Repaett
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n emeliyyati daxil edin " +
                    "\n 1-telebe yarat " +
                    "\n 2- yeni qrup yarat " +
                    "\n 3- telebenin siyahisini goster " +
                    "\n 4 - qruplarin siyahisini goster " +
                    "\n 5 - qrupa telebe elave et " +
                    "\n 6 -secilmis qrupdaki telebeleri goster " +
                    "\n 7 - sistemden cix.     \n");
                Menu();
            }

            void Menu()
            {
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Method.CreateStudent();
                        break;
                    case "2":
                        Method.CreateGroup();
                        break;
                    case "3":
                        Method.ShowStudent();
                        break;
                    case "4":
                        Method.ShowGroup();
                        break;
                    case "5":
                        Method.GroupAdd();
                        break;
                    case "6":
                        Method.ClassLenght();
                        break;
                    case "7":
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }           
        }

 
    }
}
