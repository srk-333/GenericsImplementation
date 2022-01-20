using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation
{
    internal class GenericMethod
    {
        /*Generic Method Implementation
         * Created one Method Using That we can work
         * on every data types.
         * Generic Method is useful when we need to perform same kind of work for diff data types.
         * syntax-
         * public void GenericMethod<T>(T value) 
         * Here T defines data type as per values in parameters.
         * to Fetch data from Array, We need to use For or Foreach loop.
         */
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("\nHere Using Generic Method to show all types of Array");
            foreach (var item in array)
            {
                Console.WriteLine("Array Items: "+item);
            }
        }
    }
}
