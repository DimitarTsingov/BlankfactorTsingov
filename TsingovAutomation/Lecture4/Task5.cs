using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Task5
    {
        public void Run()
        {
            // Task 5 - Count Chars in a String

            // Read input string
            string input = Console.ReadLine();

            // Dictionary to store character counts
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Iterate through each character in the input
            foreach (char c in input)
            {
                if (c != ' ') // Exclude spaces
                {
                    if (!charCounts.ContainsKey(c))
                    {
                        charCounts[c] = 0;
                    }
                    charCounts[c]++;
                }
            }

            // Print the results
            foreach (var kvp in charCounts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
