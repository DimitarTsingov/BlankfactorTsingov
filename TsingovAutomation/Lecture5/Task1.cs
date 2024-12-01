using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 1 - Find the Largest Number in an Array

namespace Lecture5
{
    public class Task1
    {
        public static int? FindLargestNumber(int[] numbers)
        {
            // Check for an empty or null array
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("The array is empty or null.");
                return null;
            }

            // Check if all numbers are negative
            if (numbers.All(n => n < 0))
            {
                Console.WriteLine("The array contains only negative numbers.");
                return null;
            }

            // Use LINQ to find the largest number in the array
            return numbers.Max();
        }

        public void Run()
        {
            // Prompt the user to enter the array size
            Console.Write("Enter the number of elements in the array: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Create an array with the specified size
            int[] numbers = new int[size];

            // Prompt the user to enter the values for the array
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }
            }

            // Find the largest number
            int? largestNumber = FindLargestNumber(numbers);

            // Output the result
            if (largestNumber.HasValue)
            {
                Console.WriteLine($"The largest number in the array is: {largestNumber.Value}");
            }
        }
    }
}
