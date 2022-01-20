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
    }
}
