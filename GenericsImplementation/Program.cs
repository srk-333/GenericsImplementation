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

            //Creating object of FindMaxValueClass.
            FindMaxValue findMaxValue = new FindMaxValue();          
            Console.WriteLine("Max number is:{0} out of numbers : {1} , {2} , {3}",findMaxValue.FindMaxInteger(first, second, third),first,second,third);
            Console.ReadLine();
        }
    }
}