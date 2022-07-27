using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX38
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            int[] a={1,1,2,3,4,5,6,1,2,3,4};
            for(i=0 ; i<a.Length ; i++)
            {
                Console.Write( a[i] + " ");
            }
            Console.WriteLine(" ");
            Console.Write("enter any array of value:");
            j = int.Parse(Console.ReadLine());
            //c=a.Count()
            Console.Write("in array:");
            Console.WriteLine(a.Count(n => n==j));
        }
    }
}
