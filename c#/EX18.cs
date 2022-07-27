using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,d,e;
            Console.Write("enter first value:");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter second value:");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                d = a + b;
                Console.Write(3 * d);
            }
            else 
            {
                e = a + b;
                Console.Write(e);
            }
        }
    }
}
