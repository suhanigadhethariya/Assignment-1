using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.Write("Input First Integer:");
            i = int.Parse(Console.ReadLine());
            Console.Write("Input second Integer:");
            j = int.Parse(Console.ReadLine());
            Console.Write("Check if one is negative and one is positive: ");
            Console.WriteLine(" ");
            if (i <= 0 && j >= 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }

            


        }
    }
}
