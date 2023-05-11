using System;
using System.ComponentModel;

namespace IteratorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var fibonacci = FibonacciSequence(8);
            foreach (int number in fibonacci)
            {
                Console.WriteLine(number);
            }

          
        }
        // https://www.c-sharpcorner.com/UploadFile/5ef30d/understanding-yield-return-in-C-Sharp/
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield
        public static IEnumerable<int> FibonacciSequence(int length)
        {
            int x = 0, y = 1;
            int sum=0;
           
            for (int i = 0; i < length; i++)
            {
                sum += x;
               yield return x ;
                int c = x + y;
               x = y;
                y = c;
               
            }
            Console.WriteLine($"Sum of Fibonacci:{sum}");
 
        }

    }
}