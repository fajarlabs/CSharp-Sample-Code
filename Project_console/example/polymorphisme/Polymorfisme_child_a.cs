using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.polymorphisme
{
    class Polymorfisme_child_a : Polymorfisme_induk
    {
        /**
         * Gunakan modifier override untuk meng-overide
         * method dari parent atau induknya
         **/
        public override void sayHello()
        {
            Console.WriteLine("Ini Child");
        }
    }
}
