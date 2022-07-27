using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,a,b,c;
            Console.Write("Enter the value:");
            i = int.Parse(Console.ReadLine());
            for (a = 1; a <= 3; a++)
            {
                Console.Write(i);
            }
            Console.WriteLine(" ");
            for (c = 1; c <= 3; c++)
            {
                for (b = 1; b <= 2; b++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(" ");
            }
            for (a = 1; a <= 3; a++)
            {
                Console.Write(i);
            }
            Console.WriteLine(" ");
        }
    }
}
