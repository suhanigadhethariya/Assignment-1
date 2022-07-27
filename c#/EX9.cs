using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l,avg;
            Console.Write("Enter the First number:");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter the First number:");
            j= int.Parse(Console.ReadLine());
            Console.Write("Enter the First number:");
            k = int.Parse(Console.ReadLine());
            Console.Write("Enter the First number:");
            l = int.Parse(Console.ReadLine());
            avg = (i + j + k + l) / 4;
            Console.WriteLine("avg:" + i + " " + j + " " + k + " " + l + " " + "=" + avg);

        }
    }
}
