using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.sealedExample
{
    /**
     *  Class ini tidak akan bisa di extend atau diturunkan ke kelas lainnya
     *  karena sudah di sealed
     */
    sealed class Example_sealed_class
    {
        public void sayHello()
        {
            Console.Write("Ini adalah class " + this.GetType());
        }
    }
}
