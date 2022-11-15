using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public static void flip(int n)
        {
            Random random = new Random();
            int number=0,tails=0,heads=0;
            while (number <= n)
            {
                int x = random.Next(1, 3);
                    if(x < 1.5)
                    tails++;
                    else
                    heads++;

                    number++;
            }
            Console.WriteLine("number of times tails achieved : {0}",tails);
            Console.WriteLine("number of times heads achieved : {0}", heads);
            float tailPercentage = (tails * 100) / n;
            float headPercentage = (heads * 100) / n;
            Console.WriteLine("\ntail percentage : {0}%",tailPercentage);
            Console.WriteLine("head percentage : {0}%", headPercentage);
        }
    }
}
