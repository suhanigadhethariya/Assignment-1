using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            float i = -1;
            int j = 4;
            int k = 6;
            Console.WriteLine("ans is=" + (i + j * k));
   
           

            int a = 35;
            int b = 5;
            float c = 7;
            Console.WriteLine("ans is=" + (a + b) % c);

            int p = 14;
            int q = -4;
            int r =6;
            int s = 11;
            Console.WriteLine("ans is=" + (p + q* r/s));

            int t = 2;
            int u =15;
            int v = 6;
            int w = 1;
            int x = 7;
            int y = 2;
            Console.WriteLine("ans is=" + (t + u / v * w - x % y));

        }
    }
}

