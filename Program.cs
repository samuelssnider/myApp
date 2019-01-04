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
               s.Add(s[s.Count - 1] + s[s.Count - 1]);
               Console.WriteLine(s[s.Count -1]);
               return s;
            }
            for(var i=0; i <= 20; i ++){
                fibonacciNumbers = fib(fibonacciNumbers);
            }
        }
    }

}
