using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.swap
{
    class PersonSwap 
    {
        public int i {set;get;}
        public string s {set;get;}
    }

    class Example_swap_class
    {

        public void swapObjectReference(PersonSwap a, PersonSwap b)
        {
            PersonSwap temp;
            temp = a;
            a = b;
            b = temp;

            /**
             * Output
             * 
             * A is : Person of B
             * B is : person of A
             **/
            Console.WriteLine("A is :"+a.s+"\n& B is :"+b.s);
        }

        // Untuk swap sekaligus melihat type yg di swap
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0} and base of T is {1}",
            typeof(T),typeof(T).BaseType);
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        public void tampilkanHasilSwap()
        {
            PersonSwap a = new PersonSwap();
            a.i = 10;
            a.s = "Person of A";

            PersonSwap b = new PersonSwap();
            b.i = 20;
            b.s = "Person of B";
            this.swapObjectReference(a,b);
            Swap<PersonSwap>(ref a, ref b);
        }
    }
}
