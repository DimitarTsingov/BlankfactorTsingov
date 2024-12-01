using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 5 - Sort an Array in Ascending Order

namespace Lecture5
{
    public class Task5
    {
        public static int[] SortArrayAscending(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("The array is empty or null.");
                return Array.Empty<int>();
            }

            // Bubble Sort algorithm
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap the numbers
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            return numbers;
        }

        public void Run()
        {
            Console.Write("Enter numbers separated by commas: ");
            string input = Console.ReadLine();

            // Parse the input into an integer array
            try
            {
                int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

                int[] sortedNumbers = SortArrayAscending(numbers);

                Console.WriteLine("Sorted array in ascending order:");
                Console.WriteLine(string.Join(", ", sortedNumbers));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter integers separated by commas.");
            }
        }
    }
}
