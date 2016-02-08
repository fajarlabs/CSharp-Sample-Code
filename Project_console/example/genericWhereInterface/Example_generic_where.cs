using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_console.package._interface;

namespace Project_console.example.genericWhereInterface
{
    /**
     * Membuat interface terlebih dahulu
     **/
    interface MyInterface
    {
        void sayHello();
    }

    /**
     * Generic akan berjalan jika class generic ini mengimplementasikan 'MyInterface' 
     * bila lebih dari satu interface maka, class genericnya harus mengimplementasikan
     * semua interface tersebut
     **/
    class MyGenericInterface<T> where T : MyInterface
    {
        private T o;

        public void setO(T o)
        {
            // Lakukan sesuatu
        }

        public T getO()
        {
            return this.o;
        }
    }

    class ImplMyInterface : MyInterface
    {
        public void sayHello()
        {
            Console.WriteLine("Say Impl Class");
        }
    }

    class Example_generic_where
    {
        public void tampilkanHasilGenericWhere()
        {
            MyGenericInterface<ImplMyInterface> mgi = new MyGenericInterface<ImplMyInterface>();
            
        }
    }
}
