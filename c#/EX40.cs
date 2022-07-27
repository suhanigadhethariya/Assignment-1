using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX40
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] a = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            foreach (int item in a)
            {
                sum = sum + item;
                Console.WriteLine(sum);
            }
        }
    }
}
