using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX34
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.Write("Input a first number:");
            i = int.Parse(Console.ReadLine());
            Console.Write("Input a first number:");
            j= int.Parse(Console.ReadLine());
            if (((i >= -10 && i <= 10)) || ((j >= -10 && j <= 10)))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
