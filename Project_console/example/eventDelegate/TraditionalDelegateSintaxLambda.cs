using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.eventDelegate
{
    class TraditionalDelegateSintaxLambda
    {
        public static void TraditionalDelegateSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Call FindAll() using traditional delegate syntax.
            Predicate<int> callback = new Predicate<int>(IsEvenNumber);

            // Mencari yang genap sesuai perhitungan modulus

            // di C# menggunakan lambda seperti berikut ini, lebih simpel
            // Now, use a C# lambda expression.
            //List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
        // Target for the Predicate<> delegate.
        static bool IsEvenNumber(int i)
        {
            // Is it an even number?
            return (i % 2) == 0;
        }
    }
}
