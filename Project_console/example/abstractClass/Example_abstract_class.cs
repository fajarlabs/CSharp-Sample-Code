using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.abstractClass
{
    abstract class Example_abstract_class
    {
        // Cara menggunakan abstract method
        // ini akan di extend pada class turunannya
        public abstract void sayHello();

        // method yang bisa dioverride
        public virtual void sayHelloOther()
        {
            Console.WriteLine("Belum di override turunannya");
        }
    }
}
