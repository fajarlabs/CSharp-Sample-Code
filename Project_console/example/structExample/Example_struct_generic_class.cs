using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.structExample
{
    struct Example_struct<T>
    {
        private T variable;

        public void setVariable(T Variable)
        {
            this.variable = Variable;
        }

        public T getVariable()
        {
            return this.variable;
        }
    }

    /**
        // Menggunakan generic int
        Example_struct <int> es =new Example_struct<int>();
        es.setVariable(5);
        Console.WriteLine(es.getVariable());
            
        // Contoh lain jika generic string
        Example_struct<String> est = new Example_struct<String>();
        est.setVariable("Halo Dunia");
        Console.WriteLine(est.getVariable());
     **/
}
