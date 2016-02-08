using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.polymorphisme
{
    class Polymorfisme_induk
    {
        /**
         * Agar bisa di override oleh child 
         * maka berikan modifier 'virtual'
         **/
        public virtual void sayHello()
        {
            Console.WriteLine("Ini induk");
        }
    }
}
