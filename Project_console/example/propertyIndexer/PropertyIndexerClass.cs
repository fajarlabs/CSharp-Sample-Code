using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.propertyIndexer
{
    class PropertyIndexerClass
    {
        private String hello_world_1;
        private String hello_world_2;

        private String this[int index]
        {
            set
            {
                if (index == 0)
                {
                    hello_world_1 = value;
                }
                else if (index == 1)
                {
                    hello_world_2 = value;
                }
                else
                {
                    Console.WriteLine("ERROR : Tidak ada indeks ke-" + index);
                    Environment.Exit(1);
                }

            }

            get
            {
                if (index == 0)
                {
                    return hello_world_1;
                }
                else if (index == 1)
                {
                    return hello_world_2;
                }
                else
                {
                    Console.WriteLine("ERROR: Tidak ada indeks ke-" + index);
                    return "Tidak ada data";
                }
            }
        }

        public void example()
        {
            PropertyIndexerClass pic = new PropertyIndexerClass();
            pic[0] = "HELLO";
            pic[1] = "WORLD";
            
            Console.WriteLine("Value 1 = "+pic[0]+ ", and Value 2 = "+pic[1]);
        }

    }
}
