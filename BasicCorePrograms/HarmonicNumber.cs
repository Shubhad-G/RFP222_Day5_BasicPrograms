using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void harmonicNumber(float n)
        {
            float harmonic = 1;
            if (n != 0)
            {
                for (int i = 0; i <= n; i++)
                {
                    harmonic +=(float)(1 / n);
                }
                Console.WriteLine("{0}th harmonic number is :{1}", n, harmonic);
            }
            else
                Console.WriteLine("enter the number greater than 0");
        }
    }
}
