using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation.FindMaximum
{
    public class FindMaxValue<T> where T : IComparable
    {
        /* UC- 4 Implemented
         * taking more then 3 parameters as in Array
         * Sorting Array to get max Value
         */
        //Instance Variables
        public T[] value;
        //Constructor
        public FindMaxValue ( T[] value)
        {
            this.value = value;
        }
        //Generic Method to sort Array in asscending order
        public T[] Sort( T[] values )
        {
            Array.Sort( values );
            return values;
        }
        //Method to get Max value After Sorting.
        public T MaxValue( params T[] values)
        {
            var sortedValues = Sort( values );
            var s = sortedValues.Length - 1;
            return sortedValues[s];
        }
        // Method to display Max Value
        public void PrintMaxValue()
        {
            Console.WriteLine("Max Value is: " +MaxValue(this.value));
        }
    }
}