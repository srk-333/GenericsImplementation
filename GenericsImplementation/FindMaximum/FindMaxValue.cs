using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation.FindMaximum
{
    public class FindMaxValue<T> where T : IComparable
    {
        /* Using Generic Class and Method to get Max value
         * extending IComparable so that that we can use CompareTo method
         */
        public T FindMax(T fisrtNum, T secondNum, T thirdNum)
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
                return default;
            }
        }
    }
}