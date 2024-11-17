using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsingovAutomation.Lecture2Homework
{
    public class Task3
    {
        public void Run()
        {
            // Input a sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Extract a substring (example: first word)
            int firstSpaceIndex = sentence.IndexOf(' ');
            if (firstSpaceIndex != -1)
            {
                string firstWord = sentence.Substring(0, firstSpaceIndex);
                string upperCaseWord = firstWord.ToUpper();

                // Display the modified substring
                Console.WriteLine($"Extracted and Uppercase Word: {upperCaseWord}");
            }
            else
            {
                Console.WriteLine("The sentence does not contain spaces to extract a word.");
            }
        }
    }
}
