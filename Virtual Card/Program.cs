using System;

namespace Virtual_Card
{
    class Program
    {
        public static int amount = 500;
        static void Main(string[] args)
        {
            
            int deposit;
            int withdraw;
            int choose;
         

            bool opp = true;
            while (opp)
            {
                Console.WriteLine("Pin kod 5 reqemli: ");
                int cardNumber = int.Parse(Console.ReadLine());

                if (cardNumber > 10000 && cardNumber < 99999)
                {
                    Console.WriteLine("Kecdi");
                    opp = false;
                }
                else
                {
                    Console.WriteLine("Say duz deyil");
                }
            }

            while (true)
            {
                Console.WriteLine("Main Card \n");

                Console.WriteLine("1.Check Balance \n");
                Console.WriteLine("2.Withdraw \n");
                Console.WriteLine("3.Deposit \n");
                Console.WriteLine("4.Create Card \n");
                Console.WriteLine("5.Exit \n");

                Console.WriteLine("Select option: ");

                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine($"\n\n\nSenin balans:{amount}");
                        break;

                    case 2:
                        Console.WriteLine("Cekilecek mebleg");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n\nMəbləgi 100-ə qeder daxil edin");
                        }
                        else if (withdraw > (amount - 30))
                        {
                            Console.WriteLine("\n\nQeyri-kafi miqdar");
                        }
                        else
                        {
                            amount -= withdraw;
                            Console.WriteLine("\n\nPulu gotur");
                            Console.WriteLine($"\nIndiki balans: {amount}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n\nDepositi artir");
                        deposit = int.Parse(Console.ReadLine());
                        amount += deposit;
                        break;

                    case 4:
                        CreateCard();
                        break;


                    case 5:
                        Console.WriteLine("\n\nTesekkurler!!!");
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }          
        }

       static void CreateCard()
        {
            bool op = true;
            while (op)
            {
                Console.WriteLine("Kart nomresi 5 reqemli: ");
                int cardNumber = int.Parse(Console.ReadLine());

                if (cardNumber > 10000 && cardNumber < 99999)
                {
                    Console.WriteLine("Kecdi");
                    op = false;
                }
                else
                {
                    Console.WriteLine("Say duz deyil");
                }

            }


            Console.WriteLine("Yeni kart ucun mebleg: ");
            int virtualAmount = int.Parse(Console.ReadLine());


            if (virtualAmount > amount)
            {
                Console.WriteLine("Esas kartdaki meblegden, cox ola bilmez");
            }
            else
            {
                amount -= virtualAmount;
                Console.WriteLine($"Qalan mebleg: {amount}");
            }



        }

    }
}
