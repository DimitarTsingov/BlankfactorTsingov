using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 2 - Reverse a String

namespace Lecture5
{
    public class Task2
    {
        public static string ReverseString(string input)
        {
            // Convert the string to a character array
            char[] charArray = input.ToCharArray();

            // Reverse the character array
            Array.Reverse(charArray);

            // Convert the reversed array back to a string
            return new string(charArray);
        }

        public void Run()
        {
            // Prompt the user to enter a string
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            // Reverse the string
            string reversedString = ReverseString(input);

            // Output the result
            Console.WriteLine($"Reversed string: {reversedString}");
        }
    }
}
