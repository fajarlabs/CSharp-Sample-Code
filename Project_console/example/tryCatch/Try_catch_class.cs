using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.tryCatch
{
    class Try_catch_class
    {
        /**
         * Simulasi method yang mengembalikan eksepsi 
         * jika terjadi kesalahan
         * selanjutnya fungsi ini harus didalam try catch
         * agar tidak terjadi error 
         **/
        public void returnException()
        {
            throw new Exception("Terjadi error");
        }

        public void testCase()
        {
            int i, j, k;
            i = 0;
            j = 1;

            try
            {
                k = j / i;
            }
            catch (Exception e)
            {
                Console.WriteLine("Pesan eksepsi : "+e.Message);    // Info exception
                Console.WriteLine("Trace error : "+e.StackTrace); // stack trace
            }
        }
    }
}
