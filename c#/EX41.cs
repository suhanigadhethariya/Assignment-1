using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] b = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (int item1 in b)
            {
                Console.Write(item1 + " ");

            }

            Console.WriteLine((a[0].Equals(b[0])) || (a[a.Length - 1].Equals(b[b.Length - 1])));
        }
    }
}
