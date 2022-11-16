using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Swap
    {
        public static void swapTwoNumbers(int a,int b)
        {
            int temp;
            Console.WriteLine("\nbefore swap first number={0}", a);
            Console.WriteLine("before swap second number={0}", b);
            temp = a;
            a=b;
            b=temp;
            Console.WriteLine("\nafter swap first number={0}", a);
            Console.WriteLine("after swap second number={0}", b);
        }
    }
}
