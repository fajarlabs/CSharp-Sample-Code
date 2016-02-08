using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.structExample
{
    class Struct_example_class
    {
        // Define struct
        struct Mobil 
        {
            public string type;
            public string getType()
            {
                return this.type;
            }
        }

        public void tampilkanStruct()
        {
            /**
             * Walaupun tidak di instansiasi struct bisa digunakan
             * dengan syarat bahwa property sudah diset/terisi dengan modifier public
             **/
            Mobil m;
            m.type = "Toyota";
            Console.WriteLine(m.getType());
        }
    }
}
