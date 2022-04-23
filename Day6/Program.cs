using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonum.fibonumber();

            //PerfectNum.perfectnumbermethod();

            //primeNum.primenumbermethod();

            //ReverseNum.reversenumbermethod();


            //watchclass obj5 = new watchclass();
            //obj5.stopwatchmethod();


            Console.WriteLine("1, 2, 5, 10, 50, 100, 500 and 1000 Rs Notes can be returned by Vending Machine.");
            Console.WriteLine("Enter the Change amount that you want ");
            int V = Convert.ToInt32(Console.ReadLine());
            int[] Notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int m = Notes.Length;
            VendorMachine obj6 = new VendorMachine();
            Console.WriteLine("Minimum Notes required is " + obj6.minNotes(Notes, m, V));
            

            Console.ReadLine();





        }
    }
}
