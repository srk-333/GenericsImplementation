using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsImplementation.FindMaximum
{
    public class FindMaxValue<T> where T : IComparable
    {
        /* UC- 5 Implemented
         * Using Generic Method to get Max Value.
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
        //Using Generic Method to get Max value
        public T PrintMaxValue()
        {
            T max = MaxValue(this.value);
            return max;
        }
    }
}