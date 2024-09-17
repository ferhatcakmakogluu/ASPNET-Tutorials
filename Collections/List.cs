using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /*
     * List<T> is like a dynamic array. It has no fixed size and automatically 
     * adjusts its size when adding or removing items.
     * T can represent any data type.
     * 
		Properties:
			- Provides access in O(1) time complexity.
			- Expands dynamically.
			- It is sequential and provides index-based access.
     */
    internal class List
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(2);
            list.Add(3);

            //list -> 1, 2, 3, 2, 3

            list.Remove(3); //The first 3 values ​​found were deleted.
            //list -> 1, 2, 2, 3
        }
    }
}
