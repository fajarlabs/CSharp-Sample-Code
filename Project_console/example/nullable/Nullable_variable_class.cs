using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.nullable
{
    class Nullable_variable_class
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;

        // Note the nullable return type.
        public int? GetIntFromDatabase()
        { 
            return numericValue; 
        }
        // Note the nullable return type.
        public bool? GetBoolFromDatabase()
        { 
            return boolValue; 
        }

        /**
         * Percobaan apabila method mengembalikan nilai null
         **/
        public static int? getIntFromDatabase()
        {
            int? i = null;
            return i;
        }

        public static void setNullableVariable()
        {
            // Jika method getInfFromDatabase mengembalikan nilai null
            // maka variabel data akan di isi nilai 100
            // cara mudah untuk ternary operator
            int data = getIntFromDatabase() ?? 100;
            Console.Write(data);
            /**
             * Bila sudah dideklarasikan seperti berikut maka ?
             * bisa diset null
             */
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
            // Error! Strings are reference types!
            // string? s = "oops";

            nullableInt = null;

            /**
             * Atau nullable seperti berikut ini dengan menggunakan
             * class Nullable
             **/
            // Define some local nullable types using Nullable<T>.
            Nullable<int> _nullableInt = 10;
            Nullable<double> _nullableDouble = 3.14;
            Nullable<bool> _nullableBool = null;
            Nullable<char> _nullableChar = 'a';
            Nullable<int>[] _arrayOfNullableInts = new int?[10];
        }
    }
}
