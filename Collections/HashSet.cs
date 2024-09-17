using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /*
     *  HashSet<T> is a collection of unique items. 
     *  This structure is ideal for storing and searching items without the need for sorting.
		Features:
			- Stores unique items.
			- Offers fast insertion, deletion and search operations (O(1)).
     */
    internal class HashSet
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int> { 1, 2, 3 };
            numbers.Add(2); // It will not be added because it is 2 in the list.

            //numbers -> 1, 2, 3

            numbers.Remove(3);
            //numbers -> 1, 2
        }
    }
}
