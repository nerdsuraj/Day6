using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Fibonum
    {
        public static void fibonumber()
        {
            //In case of fibonacci series, next number is the sum of previous two numbers for example 0, 1, 1, 2, 3, 5, 8, 13, 21 etc.The first two numbers of fibonacci series are 0 and 1.

            int n1=0;
            int n2 = 1;
            int n3, i, number;

            Console.WriteLine("Enter your number :- ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");

            for(i = 2; i < number; i++)     //i take i=2 becouse of 0 1 are already are taken
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
