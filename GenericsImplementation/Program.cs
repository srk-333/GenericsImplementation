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
            string firstName = "saurav", secondName = "Ritu", thirdName = "Ankit";

            //Creating object of FindMaxValueClass.
            FindMaxValue findMaxValue = new FindMaxValue();          
            Console.WriteLine("Max Integer number is:{0} out of numbers : {1} , {2} , {3} ", findMaxValue.FindMaxInteger(first, second, third), first, second, third +"\n");
            Console.WriteLine("Max double number is:{0} out of numbers : {1} , {2} , {3} ", findMaxValue.FindMaxDouble(f, s, t), f, s, t +"\n");
            Console.WriteLine("Max String Value is:{0} out of values : {1} , {2} , {3} ", findMaxValue.FindMaxString(firstName, secondName, thirdName), firstName, secondName, thirdName + "\n");

            //Call GenericsInvoke Method
            //Program p = new Program();
            //p.GenericsInvoke();
            Console.ReadLine();
        }

        //Method to Invoke All Generics Related classes.
        public void GenericsInvoke()
        {
            //creating Array for diff data Tpes and assigining their values.
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 10.5, 20.4, 15.6, 70.8 };
            char[] charArray = { 'A', 'B', 'c', 'd', 'f' };

            //calling Methods in PrintMethod class
            PrintMethod.ToPrint(intArray);
            PrintMethod.ToPrint(doubleArray);
            PrintMethod.ToPrint(charArray);

            //Generic Method Call
            GenericMethod.ToPrint(charArray);
            GenericMethod.ToPrint(intArray);
            GenericMethod.ToPrint(doubleArray);

            //Generic Class Using One Type
            GenericClass<int> generic = new GenericClass<int>(intArray);
            generic.ToPrint();
            GenericClass<double> generic1 = new GenericClass<double>(doubleArray);
            generic1.ToPrint();
            GenericClass<char> generic2 = new GenericClass<Char>(charArray);
            generic2.ToPrint();

            //Generic class using 2 Type.
            new GenericClassTwo<int, double>(intArray).ToPrint();
            GenericClassTwo<int, double>.Value(20.56);
        }
    }
}