using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class ReverseNum
    {
        public static void reversenumbermethod()
        {
            int n, rem;
            Console.WriteLine("Enter your number:- ");
            n=int.Parse(Console.ReadLine());

            while(n>0)
            {
                rem = n % 10;
                Console.Write(rem);
                n = n / 10;
            }
        }
    }
}
