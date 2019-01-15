using System;
using System.Collections.Generic;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> {1,1};

            List<int> fib(List<int> s){
               s.Add(s[s.Count - 1] + s[s.Count - 2]);
               return s;
            }
            for(var i=0; i <= 100; i ++){
                fibonacciNumbers = fib(fibonacciNumbers);
            }
            foreach(var item in fibonacciNumbers){
            Console.WriteLine(item);
            }
        }
    }

}
