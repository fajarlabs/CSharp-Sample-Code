using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.StringBuilderExample
{
    class TestStringBuilder
    {
        public static void example()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("HELLO ");
            sb.Append("WORLD");
            sb.Remove(0, 4);

            Console.WriteLine(sb); // Result is O WORLD
            Console.ReadLine();
        }
    }
}
