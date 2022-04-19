using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class primeNum
    {
        public static void primenumbermethod()
        {
            int i, n, count=0;
            Console.WriteLine("ENTER YOUR NUMBER :- ");
            n =int.Parse(Console.ReadLine());
            for(i = 1; i <= n; i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if (count == 2)
                Console.WriteLine("prime number ");
            else
                Console.WriteLine("not prime number");
        }
    }
}
