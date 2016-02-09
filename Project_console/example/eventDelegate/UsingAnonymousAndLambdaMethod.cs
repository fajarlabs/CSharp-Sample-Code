using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.eventDelegate
{
    public delegate int Increment(int bilangan);

    class UsingAnonymousAndLambdaMethod
    {
        // Using anonymous delegate
        static Increment obj1 = delegate(int x)
        {
            return x + 1;
        };

        // Using lambda delegate versi 1
        static Increment obj2 = (int x) =>
        {
            return x + 1;
        };

        // Using lambda delegate versi 2
        static Increment obj3 = x =>
        {
            return x + 1;
        };

        // Using lambda delegate versi 3
        static Increment obj4 = x => x + 1;

        public static void example()
        {
            Console.WriteLine(obj1(5)); // Result 6
        }
  
    }
}
