using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsImplementation.FindMaximum;

namespace GenericsImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] intArr = { 20, 80, 10, 50 };
            double[] doubleArr = { 40.5, 60.6, 35.79, 78.8 };
            string[] stringArr = {"saurav", "gourav", "Ankit" };

            /* Creating object of FindMaxValue Class passing array to the Constructor       
             * Calling PrintMaxValue Method to get Max value.
             */
            FindMaxValue<int> findMaxValue = new FindMaxValue<int>(intArr);
            findMaxValue.PrintMaxValue();
            FindMaxValue<double> findMaxValue2 = new FindMaxValue<double>(doubleArr);
            findMaxValue2.PrintMaxValue();
            FindMaxValue<string> findMaxValue3 = new FindMaxValue<string>(stringArr);
            findMaxValue3.PrintMaxValue();
            Console.ReadLine();
        }
    }
}