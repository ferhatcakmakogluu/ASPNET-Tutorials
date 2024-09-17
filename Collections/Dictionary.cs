using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /*
     *  Dictionary<Key, Value> is a structure that holds data in the form of key-value pairs. 
     *  Keys are unique and each key maps to a value.
		Properties:
			- Provides fast access to keys (O(1)).
			- Keys are unique.
			- Key-Value based.
     */
    internal class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employeeIds = new Dictionary<int, string>();
            employeeIds.Add(1, "Ferhat Cakmakoglu");
            employeeIds.Add(2, "Ahmet Tunc");
            employeeIds.Add(3, "Samet Keskin");

            foreach (var id in employeeIds)
            {
                Console.WriteLine("Key: {0} - Value: {1}",id.Key, id.Value);
            }

            Console.ReadLine();
        }
    }
}
