using System;
using System.Collections.Generic;

namespace Virtual_Card
{
    class Program
    {
        static void Main(string[] args)
        {
 

            int amount = 500;
            int deposit;
            int withdraw;
            int choose, pin = 0;
            Console.WriteLine("Your pin number: ");
            pin = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("A T M \n");

                Console.WriteLine("1.Check Balance \n");
                Console.WriteLine("2.Withdraw \n");
                Console.WriteLine("3.Deposit \n");
                Console.WriteLine("4.Exit \n");

                Console.WriteLine("Select option: ");

                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine($"\n\n\nYour balance:{amount}");
                        break;

                    case 2:
                        Console.WriteLine("Amount to be withdrawed");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw %100 !=0)
                        {
                            Console.WriteLine("\n\nEnter the amount in Multiple of 100");
                        }
                        else if (withdraw >(amount-50))
                        {
                            Console.WriteLine("\n\nInsufficient Fund");
                        }
                        else
                        {
                            amount -= withdraw;
                            Console.WriteLine("\n\n Take your Money");
                            Console.WriteLine($"\n Current balance is: {amount}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n\nEnter the amount to be deposited");
                        deposit = int.Parse(Console.ReadLine());
                        amount += deposit;
                        break;

                    case 4:
                        Console.WriteLine("\n\nThank!!!");
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
