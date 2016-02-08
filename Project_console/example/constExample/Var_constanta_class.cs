using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.constExample
{
    class Var_constanta_class
    {
        /**
         * Hanya bisa di set value sekali dan tidak bisa 
         * dirubah valuenya untuk berikutnya
         **/
        private const string myConstanta= "Halo Dunia";
        //public static const double myPhi = 3.14; // Error
        //private const string myConstanta; // Error tidak bisa di set ulang

        public void tampilkanVariabelKonstanta()
        {
            //myConstanta = "Hello World"; // Error
            Console.WriteLine(myConstanta);
        }
    }
}
