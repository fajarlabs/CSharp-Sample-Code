using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.enumExample
{
    class UsingEnumClass
    {
        enum Mobil
        {
            Honda, // = 0
            Mitsubishi, // = 1
            Mazda, // = 2
            Toyota // = 3
        }

        private void pilihMobil(Mobil m)
        {
            switch (m)
            {
                case Mobil.Honda:
                    Console.Write("Honda");
                    break;
                case Mobil.Mazda:
                    Console.Write("Mazda");
                    break;
                case Mobil.Mitsubishi:
                    Console.Write("Mitsubishi");
                    break;
                case Mobil.Toyota:
                    Console.Write("Toyota");
                    break;
            }
        }

        public void tampilkanPilihan()
        {
            this.pilihMobil(Mobil.Toyota);
        }
    }
}
