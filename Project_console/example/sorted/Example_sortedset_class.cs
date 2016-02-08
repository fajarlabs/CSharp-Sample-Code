using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.sorted
{
    /**
     * Membuat class person terlebih dahulu 
     **/
    class Person
    {
        public string Name { set; get; }
        public int Age { set; get; }
    }

    /**
     * Membuat class yang mengimplementasikan IComparer<>
     **/
    class SortByPeople : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            if (firstPerson.Age > secondPerson.Age)
                return 1;
            if (firstPerson.Age < secondPerson.Age)
                return -1;
            else
                return 0;
        }
    }

    /**
     * Membuat class untuk menguji sortedSet
     **/
    class Example_sortedset_class
    {
        public void exampleUsingSortedSet() 
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortByPeople())
            {
                new Person { Name = "Fajar", Age = 25},
                new Person { Name = "Andi", Age = 23},
                new Person { Name = "Firman", Age = 40}
            };

            // Note the items are sorted by age!
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p.Name +" "+p.Age);
            }
            Console.WriteLine();

            setOfPeople.Add(new Person { Name = "Bowo", Age = 23 });
            setOfPeople.Add(new Person { Name = "Miranda", Age = 39 });

            // Still sorted by age!
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p.Name + " " + p.Age);
            }

        }


    }
}
