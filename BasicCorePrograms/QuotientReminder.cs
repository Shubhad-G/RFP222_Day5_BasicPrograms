using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientReminder
    {
        public static void quotientReminder(int n,int x)
        {
            float quotient,reminder;
            quotient = n % x;
            reminder = n / x;
            Console.WriteLine("quotient of {1}/{2} : {0}",quotient,n,x);
            Console.WriteLine("reminder of {1}/{2} : {0}", reminder,n,x);
        }
    }
}
