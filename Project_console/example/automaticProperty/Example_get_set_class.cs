using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.automaticProperty
{
    class Example_get_set_class
    {
        // Menggunakan get set dibawah ini harus lengkap
        // antara get dan set, apabila cuma get atau set saja
        // akan terjadi error
        public string info { get; set; }

        private string data;
        public string Data
        {
            set { this.data = value; }
            get { return this.data; }
        }

        /**
         * Cara mengunnakannnya 
         *  Example_get_set_class egsc = new Example_get_set_class();
            egsc.Data = "Hasil Data";
            Console.WriteLine(egsc.Data);
            egsc.info = "INFO";
            Console.WriteLine(egsc.info);
         **/
    }
}
