using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.hasAClass
{
    class Mobil
    {
        public void info()
        {
            Console.WriteLine("Class mobil");
        }
    }
    class Has_a_class
    {
        // ini yang disebut Has_a_class 'Has-A' Mobil
        private Mobil m = new Mobil();
        public Has_a_class()
        {
            m.info();
        }
    }
}
