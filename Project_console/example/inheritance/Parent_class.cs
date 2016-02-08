using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.inheritance
{
    class Parent_class 
    {
        private string say;
        public Parent_class() { }
        public Parent_class(string Say)
        {
            this.say = Say;
        }

        public string getSay()
        {
            return this.say;
        }

        public void sayHello()
        {
            Console.WriteLine("Ini adalah Class_parent");
        }
    }
}
