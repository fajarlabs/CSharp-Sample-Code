using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.inheritance
{
    class Base_access_class : Parent_class
    {
        /**
         * Berikut cara menggunakan base() mengakses constructor
         * dari parent/induk 
         **/
        public Base_access_class() : base("Hay dari child")
        {
            Console.WriteLine(this.getSay());
        }
    }
}
