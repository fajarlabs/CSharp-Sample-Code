using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.readonlyExample
{
    class Var_readonly_class
    {
        /**
         * Data ini tidak bisa dirubah
         */
        private readonly string setHanyaSekali;
        private readonly string data = "Ini adalah data dengan modifier readonly";
        public static readonly string data_output = "Ini adalah data static dengan modifier readonly";
        public Var_readonly_class()
        {
            // Read only hanya boleh diset pada constructor
            this.setHanyaSekali = "Halo Dunia";
        }
        public void setReadOnly()
        {
            //this.setHanyaSekali = "Halo Dunia"; // Error hanya boleh diset oleh constructor saja
        }

    }
}
