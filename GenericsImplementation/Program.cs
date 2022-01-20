using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating Array for diff data Tpes and assigining their values.
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = {10.5,20.4,15.6,70.8};
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
            Console.ReadLine();
        }
    }
}