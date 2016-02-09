using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_console.example.inheritance;

namespace Project_console.example.queue
{
    class Example_queue_class
    {
        public void exampleUsingQueue()
        {
            Queue<Parent_class> s = new Queue<Parent_class>();
            s.Enqueue(new Parent_class("Parent 1"));
            s.Enqueue(new Parent_class("Parent 2"));
            s.Enqueue(new Parent_class("Parent 3"));

            // show 'Parent 1' is FIRST !
            Console.WriteLine("{0} is first in line!", s.Peek().getSay());
            Console.WriteLine("{0} remove from s", s.Dequeue());
            Console.WriteLine("{0} is first in line!", s.Peek().getSay());
        }
    }
}
