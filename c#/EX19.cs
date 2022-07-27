using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d,e,f;
            Console.Write("enter first value:");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter second value:");
            b = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                c = (a - b);
                d = 2 * c;
                Console.WriteLine(d);
            }
            else 
            {
                e = (a - b);
                f = Math.Abs(e);
                Console.WriteLine(f);
            }
        }
    }
}
