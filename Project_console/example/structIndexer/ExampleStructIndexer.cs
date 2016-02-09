using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.structIndexer
{
    // Perbedaan struct dan class. Jika struct bertype value, sedangkan class bertype referensi
    // tanpa modifier default property struct adalah public sedangkan class adalah private
    
    struct Titik
    {
        public int x, y;

        public int this[int index]
        {
            set
            {
                if (index == 0)
                {
                    this.x = value;
                }
                else if (index == 1)
                {
                    this.y = value;
                }
                else
                {
                    Console.WriteLine("ERROR: indeks salah");
                    Environment.Exit(1);
                }
            }

            get
            {
                if(index == 0) 
                {
                    return this.x;
                }
                else if (index == 1)
                {
                    return this.y;
                }
                else
                {
                    Console.WriteLine("ERROR: indeks salah");
                    return 0;
                }
            }
        }
    }

    class ExampleStructIndexer
    {
        public static void example()
        {
            Titik t = new Titik();
            t[0] = 1;
            t[1] = 2;

            Console.WriteLine(t[0]); // 1
            Console.WriteLine(t[1]); // 2
        }
    }
}
