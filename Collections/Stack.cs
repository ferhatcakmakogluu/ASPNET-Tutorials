using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /*
     *  Stack<T> is a collection that works on the basis of Last In First Out (LIFO) logic. 
     *  Items are added one on top of the other like a stack and the last item added is removed first.
		Features:
			- Works on the LIFO principle.
			- The last item added is removed first.
     */
    internal class Stack
    {
        static void Main(string[] args)
        {
            Stack<string> employee = new Stack<string>();
            employee.Push("First Employee");
            employee.Push("Second Employee");
            employee.Push("Thirth Employee");

            // LIFO -> Last In - First Out
            // First Employee -> Second Employee -> Third Employee (first element)

            Console.WriteLine(employee.Pop());
            //Output -> Thirth Employee
        }
    }
}
