using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.abstractClass
{
    class Example_extend_from_abstract_class : Example_abstract_class
    {
        public override void sayHello()
        {
            Console.WriteLine("Telah di override oleh turunannya");
        }

        public override void sayHelloOther()
        {
            Console.WriteLine("Telah di override oleh turunannya 'sayHelloOther'");
        }
    }
}
