using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation.FindMaximum
{
    public class FindMaxValue<T> where T : IComparable
    {
        /* Using Generic Class, Method and Constructor to get Max value
         * extending IComparable so that that we can use CompareTo method
         */
        //Instance Variables
        public T first, second, third;

        //Constructor to initialize data
        public FindMaxValue(T first, T second,T third)
        {
            this.first = first;
            this.second = second;   
            this.third = third;            
        }
        //Generic Method
        public static T FindMax(T fisrt, T second, T third)
        {
            //check condition for max number using CompareTo method.
            if (fisrt.CompareTo(second) > 0 && fisrt.CompareTo(third) > 0)
            {
                Console.WriteLine("Max number is First Number: " + fisrt);
                return fisrt;
            }

            if (second.CompareTo(fisrt) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Max number is Second Number: " + second);
                return second;
            }

            if (third.CompareTo(fisrt) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("Max number is Third Number: " + third);
                return third;
            }
            else
            {
                Console.WriteLine("two or more numbers are same");
                return default;
            }
        }
        //Display Method to Display data.
        public void Display()
        {
            Console.WriteLine("Max Value is: " + FindMax(first, second, third)); 
        }
    }
}