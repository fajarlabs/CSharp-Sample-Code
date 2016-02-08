using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_console.example.inheritance;

namespace Project_console.example.usingList
{
    class Example_list_class
    {
        public void exampleUsingList()
        {
            // Contoh menggunakan list untuk type primitif
            List<int> i = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Contoh penggunaan untuk type wrapper / class object
            List<Parent_class> p = new List<Parent_class> { new Parent_class("Parent 1"), new Parent_class("Parent 2")};

            // Cara untuk iterasinya bag. 1
            foreach (var o in i)
            {
                Console.WriteLine(o);
            }

            // Cara untuk iterasinya bag. 2
            foreach (var o in p)
            {
                Console.WriteLine(o.getSay());
            }

        }
    }
}
