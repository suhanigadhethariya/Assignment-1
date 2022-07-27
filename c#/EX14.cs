using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            double k;
            Console.Write("Enter the amount of celsius:");
            i = int.Parse(Console.ReadLine());
            j = i + 273;
            Console.WriteLine("Kelvin:" + (j));
            k= (int) i*1.8+32;
            Console.WriteLine("Faranhit:" + (k));
        }
    }
}


//1.80(C) + 32.