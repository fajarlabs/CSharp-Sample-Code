using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.linq
{
    class Link_query_class
    {
        public static void example1()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset) Console.Write("{0} ", i);
        }
    }
}
