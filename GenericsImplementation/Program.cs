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
            //Instanse variables.
            int first = 20, second = 300, third = 40;
            double f = 40.5, s = 60.6, t = 35.79;
            string firstName = "saurav", secondName = "gourav", thirdName = "Ankit";

            /* Creating object of FindMaxValue Class passing argument for the Constructor       
             * and calling Display method
             */
            new FindMaxValue<int>( first, second, third).Display();
            new FindMaxValue<double>(f, s, t).Display();
            new FindMaxValue<string>(firstName, secondName, thirdName).Display();
            Console.ReadLine();
        }
    }
}