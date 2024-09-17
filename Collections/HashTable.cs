using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /*
     *  Hashtable is a non-generic collection of key-value pairs. 
     *  It is similar to Dictionary but does not provide type safety.
		Properties:
			- Stores key-value pairs.
			- Does not provide type safety.
     */
    internal class HashTable
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("ID1", "Ferhat Cakmakoglu");
            hashtable.Add("ID2", "Ali Cakmakoglu");

            Console.WriteLine(hashtable["ID1"]);
            //Output -> Ferhat Cakmakoglu
        }
    }
}
