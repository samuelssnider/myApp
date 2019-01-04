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
        }
    }
}
