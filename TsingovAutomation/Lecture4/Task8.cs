using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Task8
    {
        public void Run()
        {
            // Task 8 - Basic Queue Operations

            // Read the first line of input
            int[] inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = inputParams[0]; // Number of elements to enqueue
            int s = inputParams[1]; // Number of elements to dequeue
            int x = inputParams[2]; // Element to look for

            // Read the elements to enqueue
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Initialize the queue
            Queue<int> queue = new Queue<int>();

            // Enqueue the first 'n' elements
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(elements[i]);
            }

            // Dequeue the first 's' elements
            for (int i = 0; i < s && queue.Count > 0; i++)
            {
                queue.Dequeue();
            }

            // Check if the queue contains the element 'x'
            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                // If 'x' is not found, print the smallest element in the queue or 0 if empty
                Console.WriteLine(queue.Count > 0 ? queue.Min() : 0);
            }
        }
    }
}

