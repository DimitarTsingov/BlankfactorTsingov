using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Task2
    {
        public void Run()
        {
            // Task 2 - Max Sequence of Equal Elements

            // Read the input array
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int maxLength = 1;  // To track the length of the longest sequence
            int currentLength = 1;  // To track the current sequence length
            int bestElement = array[0];  // To track the element of the longest sequence

            // Iterate through the array
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++; // Increment length of the current sequence
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength; // Update max length
                        bestElement = array[i]; // Update the element of the longest sequence
                    }
                }
                else
                {
                    currentLength = 1; // Reset current length
                }
            }

            // Print the longest sequence
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{bestElement} ");
            }
        }
    }
}
