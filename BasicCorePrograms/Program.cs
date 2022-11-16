using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter how many times coin has to be flipped");
            x=Convert.ToInt32(Console.ReadLine());
            FlipCoin.flip(x);
            Console.WriteLine("enter the year to find whether the given year is leap year or not");
            int n = Convert.ToInt32(Console.ReadLine());
            LeapYear.leapYear(n);
            Console.ReadLine();
        }
    }
}
