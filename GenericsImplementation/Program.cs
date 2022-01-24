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

            //Creating object of FindMaxValueClass        
            Console.WriteLine("Max Integer number is:{0} out of numbers : {1} , {2} , {3} ", new FindMaxValue<int>().FindMax(first, second, third), first, second, third + "\n");
            Console.WriteLine("Max double number is:{0} out of numbers : {1} , {2} , {3} ", new FindMaxValue<double>().FindMax(f, s, t), f, s, t +"\n");
            Console.WriteLine("Max String Value is:{0} out of values : {1} , {2} , {3} ", new FindMaxValue<string>().FindMax(firstName, secondName, thirdName), firstName, secondName, thirdName + "\n");
            Console.ReadLine();
        }
    }
}