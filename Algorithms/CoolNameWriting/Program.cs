using System;

namespace CoolNameWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name=Console.ReadLine();
           
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();

            int lengthName = name.Length;
            while (lengthName%12!=0)
            {
                name = name + "+";
                lengthName = name.Length;
            }

            int lengthSurname =surname.Length;
            while (lengthSurname % 12 != 0)
            {
                surname = surname + "+";
                lengthSurname = surname.Length;
            }

            int lengthPartName = name.Length / 4;
            int voidNumber = lengthPartName - 2;

            string voidName = "";
            while (voidName.Length<voidNumber)
            {
                voidName = voidNumber + " ";
            }

            string namePart1 = name.Substring(0, lengthPartName);
            string namePart2 = name.Substring(lengthPartName, 2*lengthPartName);
            string namePart3 = name.Substring(2*lengthPartName, 2 * lengthPartName);
            string namePart4 = name.Substring(4*lengthPartName, 4 * lengthPartName);

            Console.WriteLine(namePart1);
            int i = 0;
            while (i<lengthPartName)
            {
                int j = lengthPartName - 1 - i;
                Console.WriteLine(namePart2.Substring(i,i+1)+voidName+namePart4.Substring(j,j+1));
                i = i + 1;
            }
            Console.WriteLine(namePart3);
            Console.WriteLine("");
            Console.WriteLine("-----------------");
            Console.WriteLine("");



        }
    }
}
