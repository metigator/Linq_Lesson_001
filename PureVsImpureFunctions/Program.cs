using System;
using System.Collections.Generic;

namespace PureVsImpureFunctions
{
    internal class Program
    {
        static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        static void Main(string[] args)
        {
            
            //Print(numbers);

            // AddInteger1(3);

            //var x = 2;
            //AddInteger2(ref x);

            //AddInteger3();

            var newList = AddInteger4(numbers, 3);
            Console.WriteLine("old list");
            Print(numbers);
            Console.WriteLine("new list");
            Print(newList);

            Console.ReadKey();
        }

        static void Print(List<int> source)
        {
            foreach (var item in source)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
        }

        static void AddInteger1(int num)
        {
            numbers.Add(num); // impure mutate global variable
        }

        static void AddInteger2(ref int num)
        {
            num++; // impure mutate parameter
            numbers.Add(num);
        }

        static void AddInteger3()
        { 
            numbers.Add(new Random().Next()); // impure interation with outside world
        }

        static List<int> AddInteger4(List<int> numbers, int num)
        {
            var result = new List<int>(numbers); // 
            result.Add(num);
            return result;
        }
    }
}
