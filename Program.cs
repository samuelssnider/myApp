using System;
using System.Collections.Generic;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Ignacio", "Sam", "Ashleigh"};
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"The list has {names.Count} people in it");
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Sam");
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"The list has {names.Count} people in it");
            names.Sort();
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"The list has {names.Count} people in it");
        }
    }
}
