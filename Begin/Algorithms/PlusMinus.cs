using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Result
    {
        public static void plusMinus(List<int> arr)
        {
            decimal p = 0;
            decimal n = 0;
            decimal z = 0;
            decimal length = arr.Count;


            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0) n++;
                else if (arr[i] > 0) p++;
                else z++;
            }
            Console.WriteLine(p / length);
            Console.WriteLine(n / length);
            Console.WriteLine(z / length);
        }

    }
}
