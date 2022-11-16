using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void leapYear(int n)
        {
            if (n > 999 && n < 10000)
            {
                if (n % 4 == 0)
                    Console.WriteLine("{0} year is Leap year", n);
                else if (n % 400 == 0)
                    Console.WriteLine("{0} year is Leap year", n);
                else if (n % 100 == 0)
                    Console.WriteLine("{0} year is not a Leap year", n);
                else
                    Console.WriteLine("{0} year is not a Leap year", n);
            }
            else
                Console.WriteLine("incorrect input,enter 4 digit number for year");
        }
    }
}
