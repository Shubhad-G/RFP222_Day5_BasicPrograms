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
            Console.ReadLine();
        }
    }
}
