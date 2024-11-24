using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Task7
    {
        public void Run()
        {
            // Task 7 - Basic Stack Operations

            // Read the first line of input
            int[] inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = inputParams[0]; // Number of elements to push
            int s = inputParams[1]; // Number of elements to pop
            int x = inputParams[2]; // Element to look for

            // Read the elements to push onto the stack
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Initialize the stack
            Stack<int> stack = new Stack<int>();

            // Push the first 'n' elements onto the stack
            for (int i = 0; i < n; i++)
            {
                stack.Push(elements[i]);
            }

            // Pop the top 's' elements from the stack
            for (int i = 0; i < s && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            // Check if the stack contains the element 'x'
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                // If 'x' is not found, print the smallest element in the stack or 0 if empty
                Console.WriteLine(stack.Count > 0 ? stack.Min() : 0);
            }
        }
    }
}
