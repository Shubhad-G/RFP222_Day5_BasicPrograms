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
            int option;
            Console.WriteLine("options:\n1.Flip coin program\n2.Leap year program\n3.Power of 2 table program\n4.Harmonic number\n5Prime Factors\n6.Quotient and reminder\n7.Swaping of two numbers\n8.Even or odd\n9.Vowel or consanant\n10.Largest among three");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int x;
                    Console.WriteLine("enter how many times coin has to be flipped");
                    x = Convert.ToInt32(Console.ReadLine());
                    FlipCoin.flip(x);
                    break;
                case 2:
                    Console.WriteLine("enter the year to find whether the given year is leap year or not");
                    int n = Convert.ToInt32(Console.ReadLine());
                    LeapYear.leapYear(n);
                    break;
                case 3:
                    Console.WriteLine("enter a number within 32");
                        int p=Convert.ToInt32(Console.ReadLine());
                    PowerOf2Table.powerOf2(p);
                    break;
                case 4:
                    Console.WriteLine("enter a number to find nth harmonic number");
                    float harmonic=(float)(Convert.ToSingle(Console.ReadLine()));
                    HarmonicNumber.harmonicNumber(harmonic);
                    break;
                case 5:
                    Console.WriteLine("enter a number");
                    int k = Convert.ToInt32(Console.ReadLine());
                    PrimeFactors.primeFactors(k);
                    break;
                case 6:
                    Console.WriteLine("enter two numbers to find the quotient and reminder");
                    Console.WriteLine("enter the first number");
                    int one=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the second number");
                    int two = Convert.ToInt32(Console.ReadLine());
                    QuotientReminder.quotientReminder(one, two);
                    break;
                case 7:
                    Console.WriteLine("enter first number");
                    int firstNumber=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter second number");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    Swap.swapTwoNumbers(firstNumber, secondNumber);
                    break;
                case 8:
                    Console.WriteLine("enter a number to find whether a given number is even or odd");
                    int num=Convert.ToInt32(Console.ReadLine());
                    EvenOdd.evenOdd(num);
                    break;
                case 9:
                    Console.WriteLine("enter an alphabet to find whether it is vowel or consonant");
                    char s=Convert.ToChar(Console.ReadLine());
                    VowelConsonant.vowelConsonant(s);
                    break;
                case 10:
                    Console.WriteLine("enter three numbers\nenter the first number");
                    int firstNum=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the second number");
                    int secondNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the third number");
                    int thirdNum = Convert.ToInt32(Console.ReadLine());
                    LargestOfThree.largestOf3(firstNum, secondNum, thirdNum);
                    break;
            }     
            Console.ReadLine();
        }
    }
}
