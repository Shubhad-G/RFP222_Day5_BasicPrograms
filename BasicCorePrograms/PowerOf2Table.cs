using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf2Table
    {
        public static void powerOf2(int n)
        {
            int power = 1;
            if (n < 32)
            {
                for (int i = 1; i <= n; i++)
                {
                    power *= 2;
                    Console.WriteLine("2^{0} = {1}",i,power);
                }
            }
            else
                Console.WriteLine("enter the number within 32");
        }
    }
}
