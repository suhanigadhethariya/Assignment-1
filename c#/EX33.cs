using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX33
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("enter first value:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("enter secound value:");
            j = int.Parse(Console.ReadLine());
            if (i < 100 && j > 200)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
