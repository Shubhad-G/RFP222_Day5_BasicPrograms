using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactors
    {
        public static void primeFactors(int n)
        {
            Console.Write($"Prime Factors of {n} are:  ");

            // Prints all the numbers of 2  
            while (n % 2 == 0)
            {
                Console.WriteLine("2 ");
                n /= 2;
            }

            // As no 2 can be further divided, this probably means that n
            // is now an odd number
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine($"{i} ");
                    n /= i;
                }
            }

            // This is for case if n is greater than 2
            if (n > 2)
            {
                Console.WriteLine($"{n} ");
            }

        }
    }
}
