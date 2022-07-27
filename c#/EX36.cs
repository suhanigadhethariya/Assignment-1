using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,d,e;
            Console.WriteLine("enter first value:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter secound value:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third value:");
            c = int.Parse(Console.ReadLine());
            d = Math.Max(a, Math.Max(b,c));
            e=Math.Min(a,Math.Min(b,c));
            Console.Write("Maximum value:" + d);
            Console.WriteLine();
            Console.Write("Minimum value:" + e);
        }
    }
}
