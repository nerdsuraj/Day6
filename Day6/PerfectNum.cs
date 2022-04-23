using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class PerfectNum
    {
        public static void perfectnumbermethod()
        {
            int i;
            int sum = 0;
            int n;

            Console.WriteLine("Enter your number :- ");
            n=int.Parse(Console.ReadLine());

            for(i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    sum=sum+i;
                }
            }
            if (n == sum)
                Console.WriteLine(" perfect number ");
            else
                Console.WriteLine(" not perfect number ");
        }
    }
}
