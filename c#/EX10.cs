using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k,a,b;
            Console.Write("Enter first number:");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter first number:");
            j = int.Parse(Console.ReadLine());
            Console.Write("Enter first number:");
            k= int.Parse(Console.ReadLine());
            a=(i+j)*k;
            b=(i*j)+(j*k);
            Console.WriteLine("answer is:"+a);
            Console.WriteLine("answer is:"+b);


        }
    }
}


