using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Task1
    {
        public void Run()
        {
            // Task 1 - Common Elements

            // Read two arrays from input
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            // Find and print common elements
            foreach (string element in secondArray)
            {
                if (Array.Exists(firstArray, e => e == element))
                {
                    Console.Write($"{element} ");
                }
            }
        }
    }
}
