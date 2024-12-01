using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 7 - Update Array Elements

namespace Lecture5
{
    public class Task7
    {
        public static void MultiplyElements(ref int[] array, int factor)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("The array is empty or null.");
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= factor;
            }
        }

        public void Run()
        {
            Console.Write("Enter array elements separated by commas: ");
            string input = Console.ReadLine();

            try
            {
                int[] array = Array.ConvertAll(input.Split(','), int.Parse);

                Console.Write("Enter the multiplication factor: ");
                if (!int.TryParse(Console.ReadLine(), out int factor))
                {
                    Console.WriteLine("Invalid factor. Please enter a valid integer.");
                    return;
                }

                Console.WriteLine("Original array: " + string.Join(", ", array));

                MultiplyElements(ref array, factor);

                Console.WriteLine("Updated array: " + string.Join(", ", array));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter integers separated by commas.");
            }
        }
    }
}
