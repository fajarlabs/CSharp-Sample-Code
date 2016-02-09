using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_console.example.inheritance;

namespace Project_console.example.stack
{
    class Example_stack_class
    {
        public void exampleUsingStack() 
        {
            /**
             * Didalam class Stack terdapat member yang bernama Push() dan Pop()
             * untuk memasukkan item atau menghapus item 
             **/
            Stack<Parent_class> s = new Stack<Parent_class>();
            s.Push(new Parent_class("Parent 1"));
            s.Push(new Parent_class("Parent 2"));
            s.Push(new Parent_class("Parent 3"));

            // LIFO last in first out
            // Show is 'Parent 3'
            Console.WriteLine("First parent is: {0}", s.Peek().getSay());
            // Get pop and remove pop
            Console.WriteLine("Popped off {0}", s.Pop().getSay());

            Console.WriteLine("\nFirst parent is: {0}", s.Peek().getSay());
            // Get pop and remove pop again..
            Console.WriteLine("Popped off {0}", s.Pop().getSay());

            Console.WriteLine("\nFirst parent item is: {0}", s.Peek().getSay());
            // Get pop and remove pop again..
            Console.WriteLine("Popped off {0}", s.Pop().getSay());

            // Get pop and remove pop
            // Error exception 
            // terjadi karena stack sudah habis
            try
            {
                Console.WriteLine("\nnFirst person is: {0}", s.Peek());
                Console.WriteLine("Popped off {0}", s.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }
        }
    }
}
