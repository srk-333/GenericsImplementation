using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation
{
    /*Creating Generic Class
    * using 1 Types place holder as T
    * creating Constructor of Generic Class
    * so, that array values can be initialized during object Creation of class.
    * place Holder name can be AnyThing.
    * var is a kind data types which is used,
    * when we dnt know which data types we will get.
    * var itself defines data types of each values at Compile Time.
    */
    internal class GenericClass<T>
    {
        public T[] array;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericClass{T}"/> class.
        /// </summary>
        /// <param name="array">The array.</param>
        public GenericClass(T[] array)
        {
            this.array = array;
        }
        public void ToPrint()
        {
            Console.WriteLine("Using Generic class to print Array Element");
            foreach (var item in array)
                Console.WriteLine("Element in Array: " + item);
        }
    }
}
