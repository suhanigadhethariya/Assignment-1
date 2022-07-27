using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX31
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("enter value:");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                if (a % 3 == 0 || a % 7 == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine(" not positiv ");
            }
        }
    }
}
