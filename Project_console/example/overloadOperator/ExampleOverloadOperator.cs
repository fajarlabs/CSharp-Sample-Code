using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.overloadOperator
{
    class Bilangan
    {
        // Tempat pengujian
        private int nilai;

        // Constructor
        public Bilangan(int nilai)
        {
            this.nilai = nilai;
        }

        // Property nilai
        public int Nilai
        {
            set
            {
                nilai = value;
            }
            get
            {
                return nilai;
            }
        }

        public static void example()
        {
            Bilangan a = new Bilangan(2);
            Bilangan b = new Bilangan(2);

            Bilangan c = a + b;
            Console.WriteLine(c.nilai);

            // result is 4
        }

        // Overload operator penambahan
        public static Bilangan operator + (Bilangan bil1, Bilangan bill2)
        {
            return new Bilangan(bil1.nilai + bill2.nilai);
        }

        // Overload operator pengurangan
        public static Bilangan operator -(Bilangan bil1, Bilangan bil2)
        {
            return new Bilangan(bil1.nilai - bil2.nilai);
        }

        // Overload operator pembagian
        public static Bilangan operator /(Bilangan bil1, Bilangan bil2)
        {
            return new Bilangan(bil1.nilai / bil2.nilai);
        }

        // Overload terhadap operator unary
        // Contohnya kita mengoverload ++ dan --

        // Operator unary ++
        public static Bilangan operator ++(Bilangan bil)
        {
            return new Bilangan(bil.nilai + 1);
        }

        // Operator unary --
        public static Bilangan operator --(Bilangan bil)
        {
            return new Bilangan(bil.nilai - 1);
        }

        // Mengoverload terhadap kunci true dan false

        // Meng-overload true
        public static bool operator true(Bilangan bil)
        {
            return (bil.nilai != 0);
        }

        // Meng-overload false
        public static bool operator false(Bilangan bil)
        {
            return (bil.nilai == 0);
        }


        // Contoh yang lain tinggal di implementasikan seperti diatas
    }
}
