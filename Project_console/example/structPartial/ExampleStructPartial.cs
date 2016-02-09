using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.structPartial
{
    partial struct Titik
    {
        private int x;
        private int y;

        public Titik(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    partial struct Titik
    {
        public int X
        {
            set
            {
                this.x = value;
            }

            get
            {
                return this.x;
            }
        }

        public int Y
        {
            set
            {
                this.y = value;
            }

            get
            {
                return this.y;
            }
        }

    }
    class ExampleStructPartial
    {
        public static void Example()
        {
            // Using partial part 1
            Titik t = new Titik(5, 10);

            // Using partial part 2
            t.X = 6;
            t.Y = 7;

            Console.WriteLine(t.X + t.Y); // result is 13
        }
    }
}
