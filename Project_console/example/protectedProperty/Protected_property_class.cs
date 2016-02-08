using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.protectedProperty
{
    class Protected_property_class
    {
        /**
         * Property hanya bisa diakses oleh class itu sendiri dan turunannya saja
         **/
        protected string var_a = "Hello";
        protected string var_b = "World";
    }
}
