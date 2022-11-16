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
            int option;
            Console.WriteLine("options:\n1.Flip coin program\n2.Leap year program\n3.Power of 2 table program\n4.Harmonic number");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int x;
                    Console.WriteLine("enter how many times coin has to be flipped");
                    x = Convert.ToInt32(Console.ReadLine());
                    FlipCoin.flip(x);
                    break;
                case 2:
                    Console.WriteLine("enter the year to find whether the given year is leap year or not");
                    int n = Convert.ToInt32(Console.ReadLine());
                    LeapYear.leapYear(n);
                    break;
                case 3:
                    Console.WriteLine("enter a number within 32");
                        int p=Convert.ToInt32(Console.ReadLine());
                    PowerOf2Table.powerOf2(p);
                    break;
                case 4:
                    Console.WriteLine("enter a number to find nth harmonic number");
                    float harmonic=(float)(Convert.ToSingle(Console.ReadLine()));
                    HarmonicNumber.harmonicNumber(harmonic);
                    break;
            }     
            Console.ReadLine();
        }
    }
}
