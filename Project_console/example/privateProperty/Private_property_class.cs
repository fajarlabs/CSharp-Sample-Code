using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.privateProperty
{
    class Private_property_class
    {
        /**
         * Property ini hanya bisa diakses oleh
         * class itu sendiri, bukan turunnya maupun public
         **/
        private string var_a = "Halo";
        private string var_b = "Dunia";
    }
}
