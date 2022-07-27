using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter your age:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("You look older than:" + Math.Abs(i));

        }
    }
}
