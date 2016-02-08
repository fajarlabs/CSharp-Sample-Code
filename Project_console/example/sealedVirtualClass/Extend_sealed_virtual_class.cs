using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.sealedVirtualClass
{
    class Extend_sealed_virtual_class : Virtual_class
    {
        /**
         * Method ini dikunci/sealed dan tidak bisa diturunkan
         **/
        public sealed override void sayHello() 
        {
            Console.WriteLine("Say sealed method override");
        }
    }
}
