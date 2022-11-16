using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelConsonant
    {
        public static void vowelConsonant(char s)
        {
            if (s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u')//small letters
                Console.WriteLine("{0} is a vowel",s);
           else if (s == 'A' || s == 'E' || s == 'I' || s == 'O' || s == 'U')//CAPITAL LATTERS
                Console.WriteLine("{0} is a vowel", s);
            else
                Console.WriteLine("{0} is a consonant", s);
        }
    }
}
