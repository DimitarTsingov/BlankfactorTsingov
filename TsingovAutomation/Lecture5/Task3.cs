using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 3 - Generate Fibonacci Sequence

namespace Lecture5
{
    public class Task3
    {
        public static List<int> GenerateFibonacci(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("The number must be greater than zero.");
                return new List<int>();
            }

            List<int> fibonacciSequence = new List<int>();

            // Handle the first n numbers in the sequence
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    fibonacciSequence.Add(0);
                else if (i == 1)
                    fibonacciSequence.Add(1);
                else
                    fibonacciSequence.Add(fibonacciSequence[i - 1] + fibonacciSequence[i - 2]);
            }

            return fibonacciSequence;
        }

        public void Run()
        {
            Console.Write("Enter the number of Fibonacci numbers to generate: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                List<int> fibonacci = GenerateFibonacci(n);

                if (fibonacci.Count > 0)
                {
                    Console.WriteLine($"The first {n} numbers in the Fibonacci sequence are:");
                    Console.WriteLine(string.Join(", ", fibonacci));
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}
