using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestOfThree
    {
        public static void largestOf3(int a,int b, int c)
        {
            if (a > b && a > c)
                Console.WriteLine("{0} is largest", a);
            else if (b > c)
                Console.WriteLine("{0} is largest", b);
            else
                Console.WriteLine("{0} is largest", c);
        }
    }
}
