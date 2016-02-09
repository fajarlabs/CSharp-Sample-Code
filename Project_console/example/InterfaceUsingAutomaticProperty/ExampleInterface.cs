using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.InterfaceUsingAutomaticProperty
{
    interface MyInterface
    {
        string MyName
        {
            set;
            get;
        }
    }

    class ExampleInterface : MyInterface
    {
        private string myname;

        // Implementasi interface automatic property
        public string MyName
        {
            set
            {
                myname = value;
            }
            get
            {
                return myname;
            }
        }

        public static void example()
        {
            ExampleInterface ei = new ExampleInterface();
            ei.myname = "HELLO WORLD";
            Console.WriteLine(ei.myname);
        }
    }
}
