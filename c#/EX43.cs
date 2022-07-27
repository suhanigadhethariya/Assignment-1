using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX43
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5 };
            int[] b = { 0, 3, 8 };
            int[] c = { -1, 0, 2 };
            int[] d = { a[1], b[1], c[1] };
            Console.Write("new array:");
            foreach (int item in d)
            {
                Console.Write(item+" ");
            }
        }
    }
}
