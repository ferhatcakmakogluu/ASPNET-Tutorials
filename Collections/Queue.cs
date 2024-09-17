using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /*
     *  Queue<T> is a FIFO (First In First Out) collection. 
     *  It is typically used when items added to a queue need to be processed sequentially.
		Features:
			- Works on the FIFO principle.
			- Processes items in order.
     */
    internal class Queue
    {
        static void Main(string[] args)
        {
            Queue<string> employee = new Queue<string>();
            employee.Enqueue("First Employee");
            employee.Enqueue("Second Employee");
            employee.Enqueue("Thirth Employee");


            //FIFO -> First In - First Out
            // Third Employee -> Second Employee -> First Employee (first element)

            Console.WriteLine(employee.Dequeue());
            //Output -> First Employee

        }
    }
}
