using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Delegate adalah tipe, sama halnya seperti kelas.
// Delegate harus didelegasikan dahulu sebelum digunakan.
// Deklarasi tipe delegate harus ditulis diluar kelas.
// Delegate sebenarnya merupakan perwakilan dari suatu metode.

namespace Project_console.example.eventDelegate
{
    // Mendeklarasikan tipe delegasi
    delegate double OperasiBilangan(double a, double b);

    // Delegate balik dan cetak
    public delegate void BalikDanCetak(StringBuilder sb);

    class ExampleDelegate
    {
        static double Tambah(double bil1, double bil2)
        {
            return bil1 + bil2;
        }

        static double Kurang(double bil1, double bil2)
        {
            return bil1 - bil2;
        }

        static double Bagi(double bil1, double bil2)
        {
            return bil1 / bil2;
        }

        static double Kali(double bil1, double bil2)
        {
            return bil1 * bil2;
        }

        // Metode yang membalik string
        static void Metode1(StringBuilder sb)
        {
            char[] temp = new char[sb.Length];
            int j = 0;
            for (int i = sb.Length-1; i >= 0; i--, j++)
            {
                temp[j] = sb[i];
            }

            sb.Clear();
            sb.Append(new String(temp));
        }

        // Metode yang menampilkan string
        static void Metode2(StringBuilder sb)
        {
            Console.WriteLine(sb);
        }

        public static void Example()
        {
            // Menginstansiasi delegate
            // Lalu delegasikan methode diatas dengan cara
            // menuliskan nama metode tersebut kedalam operasi bilangan
            StringBuilder sb = new StringBuilder("DLROW OLLEH");
            BalikDanCetak ob;
            // Menambahkan metode kedalam delegasi
            ob = Metode1; // Metode yang berfungsi untuk membalik karakter
            ob += Metode2; // Metode untuk menampilkan hasil dari metode 1
            ob(sb);

            // cara kedua
            OperasiBilangan ob2 = ExampleDelegate.Kali;
            //Console.WriteLine(ob2(2, 2));
        }
    }

    // Selain cara diatas, ada cara lain menggunakan delegate
    // dengan menggunakan "Invoke"
}
