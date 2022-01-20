using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation.FindMaximum
{
    internal class FindMaxValue
    {
        /*Method to check Max number out of Three number
         * If any two or all numbers are same then return zero.
         */
        public int FindMaxInteger(int fisrtNum, int secondNum, int thirdNum)
        {
            //check condition for max number using CompareTo method.
            if (fisrtNum.CompareTo(secondNum) > 0 && fisrtNum.CompareTo(thirdNum) > 0)
            {
                Console.WriteLine("Max number is First Number: " + fisrtNum);
                return fisrtNum;
            }

            if (secondNum.CompareTo(fisrtNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                Console.WriteLine("Max number is Second Number: " + secondNum);
                return secondNum;
            }

            if (thirdNum.CompareTo(fisrtNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                Console.WriteLine("Max number is Third Number: " + thirdNum);
                return thirdNum;
            }
            else
            {
                Console.WriteLine("two or more numbers are same");
                return 0;
            }
        }

        //Mehod for Double type data value
        public double FindMaxDouble(double first, double second, double third)
        {
            //check condition for max number using CompareTo method.
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("Max number is First Number: " + first);
                return first;
            }

            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Max number is Second Number: " + second);
                return second;
            }

            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("Max number is Third Number: " + third);
                return third;
            }
            else
            {
                Console.WriteLine("two or more numbers are same");
                return 0;
            }
        }
    }
}