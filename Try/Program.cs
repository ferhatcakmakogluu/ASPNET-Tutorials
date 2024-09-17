using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("ID1", "Ferhat Cakmakoglu");
            hashtable.Add("ID2", "Ali Cakmakoglu");

            Console.WriteLine(hashtable["ID1"]);

        }
    }
}
