using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX37
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,a,b,c;
            Console.WriteLine("Input first integer:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Input first integer:");
            j = int.Parse(Console.ReadLine());
            if (i == j)
            {
                Console.WriteLine("0");
            }
            else
            {
                a = Math.Max(i, j);
                Console.WriteLine(a);
            }      


        }
    }
}
