using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 4 - Check for Prime Numbers

namespace Lecture5
{
    public class Task4
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; // 0 and 1 are not prime numbers
            }

            // Check divisors from 2 up to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; // If divisible, it's not a prime number
                }
            }

            return true; // It's a prime number
        }

        public void Run()
        {
            Console.Write("Enter a number to check if it's prime: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                bool result = IsPrime(number);
                Console.WriteLine(result
                    ? $"{number} is a prime number."
                    : $"{number} is not a prime number.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
