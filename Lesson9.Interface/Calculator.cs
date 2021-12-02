using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Sum(3,5,6));
            Console.WriteLine(calculator.Multiply(4,5,3));
            Console.WriteLine(calculator.Divide(20,5));
            Console.WriteLine(calculator.Difference(35,8));


            ////Console.WriteLine("hesab novu");
            ////string select = Console.ReadLine();
            ////Console.WriteLine("eded daxl et");
            ////double a = Convert.ToDouble(Console.ReadLine());
            ////double b = Convert.ToDouble(Console.ReadLine());
            ////double c = Convert.ToDouble(Console.ReadLine());


            ////switch (select)
            ////{
            ////    case "1":
            ////        Console.WriteLine(calculator.Sum(a, b, c));
            ////        break;
            ////    case "2":
            ////        Console.WriteLine(calculator.Multiply(a, b, c));
            ////        break;
            ////    case "3":
            ////        Console.WriteLine(calculator.Divide(a, b, c));
            ////        break;
            ////    case "4":
            ////        Console.WriteLine(calculator.Difference(a, b, c));
            ////        break;
            ////    default:
            ////        break;
            ////}
        }
    }


    ////////////////////////////Interface///////////////////////
    interface ISum
    {
        public double Sum(params double[] list);
    }
    interface IMultiply 
    {
        public double Multiply(params double[] list);
    }
    interface IDifference
    {
        public double Difference(params double[] list);
    }
    interface IDivide
    {
        public double Divide(params double[] list);
    }

    
    
    /////////////////////////METHOD////////////////////////////
    class Calculator : ISum, IMultiply, IDifference, IDivide
{
        public double Sum(params double[] list)
        {
            double sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum; 
        }

        public double Multiply(params double[] list)
        {
            double mul = 1;
            for (int i = 0; i < list.Length; i++)
            {
                mul *= list[i];
            }
            return mul;
        }

        public double Divide(params double[] list)
        {
            double div = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                div /= list[i];
            }
            return div;
        }

        public double Difference(params double[] list)
        {
            double dif = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                dif -= list[i];
            }
            return dif;
        }

    }
}
