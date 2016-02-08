using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.writeLineFormat
{
    class Example_writeln_class
    {
        public void showExampleWriteLine()
        {
            /**
             * Seperti sprintf, setelah string dilanjutkan dengan value yang
             * dimulai dengan index {0},{1} dan seterusnya
             **/
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine("OS: {0} And Number of processors {1} And .NET Version: ", Environment.OSVersion, Environment.ProcessorCount, Environment.Version);

            /**
             * Other example format
                C or c Used to format currency. By default, the flag will prefix the local cultural
                symbol (a dollar sign [$] for U.S. English).
                D or d Used to format decimal numbers. This flag may also specify the
                minimum number of digits used to pad the value.
                E or e Used for exponential notation. Casing controls whether the exponential
                constant is uppercase (E) or lowercase (e).
                F or f Used for fixed-point formatting. This flag may also specify the minimum
                number of digits used to pad the value.
                G or g Stands for general. This character can be used to format a number to fixed
                or exponential format.
                N or n Used for basic numerical formatting (with commas).
                X or x Used for hexadecimal formatting. If you use an
             **/
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
        }
    }
}
