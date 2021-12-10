using System;
using System.Collections.Generic;

namespace ImparativeVsDeclarative
{
    // public delegate void Del1();
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Person> people = new []
            {
                new Person { Name =  "Ali Saleh", Age = 34, Telephone = "+1(123)456-7890"},
                new Person { Name =  "Rim Salem", Age = 19, Telephone = "+1(123)456-7891"},
                new Person { Name =  "Ola Salam", Age = 44, Telephone = "+1(123)456-7892"},
                new Person { Name =  "Huda Mohd", Age = 32, Telephone = "+1(123)456-7893"},
                new Person { Name =  "Omar Kadi", Age = 28, Telephone = "+1(123)456-7894"}
            };

            // Print(people);

            //var result = FilterPeopleWithAgeLessThan(people, 30);
            //Console.WriteLine("Age Less Than 30");
            //Console.WriteLine("---------------");

            //var result = FilterPeopleWithAgeEqual(people, 32);
            //Console.WriteLine("Age = 32");
            //Console.WriteLine("---------------");
            //Print(result);

            //Method2(Method1);

            Func<Person, bool> predicate = p => p.Age >= 32;

            var result = Filter(people, predicate);
            Console.WriteLine("Age >= 32");
            Console.WriteLine("---------------");
            Print(result);

            Console.ReadKey();
        }
        
        static IEnumerable<Person> FilterPeopleWithAgeLessThan(IEnumerable<Person> people, int age)
        {
            foreach (var item in people)
            {
                if (item.Age <= age)
                    yield return item;
            }
        }

        static IEnumerable<Person> FilterPeopleWithAgeEqual(IEnumerable<Person> people, int age)
        {
            foreach (var item in people)
            {
                if (item.Age == age)
                    yield return item;
            }
        }

        static IEnumerable<Person> Filter(IEnumerable<Person> people, Func<Person, bool> predicate)
        {
            foreach (var item in people)
            {
                if (predicate(item))
                    yield return item;
            }
        }


        static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        static void Method2(Action method1)
        {
            method1();
            Console.WriteLine("Method 2");
        }

         

        static void Print(IEnumerable<Person> people)
        {
            foreach (Person p in people)
            {
                Console.Write(" {");
                Console.Write($" Name: \"{p.Name}\"");
                Console.Write($", Age: {p.Age}");
                Console.Write($", Telephone: \"{p.Telephone}\"");
                Console.Write(" }");
                Console.WriteLine();
            }
        }
    }
}
