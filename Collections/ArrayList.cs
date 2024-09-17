using System;
using System.Collections;

namespace Collections
{
    /*
     *  An ArrayList is a collection that can hold items of any data type. 
     *  However, since there is no type safety, different data types can exist in the same ArrayList. 
     *  ArrayList is one of the most widely used non-generic collections.
		Properties:
			- Dynamic size.
			- It is not type-safe.
     */
    internal class ArrayList
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Iki");
            list.Add(3.4);

            //list -> 1, "Iki", 3.4

            list.Remove(3.4); // We deleted the value 3.4 with the Remove function
            list.RemoveAt(1); // We deleted the value in the first index with the RemoveAt function

            //list -> 1
        }
    }
}
