using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 9 - Parse String to Number

namespace Lecture5
{
    public class Task9
    {
        public static int ParseStringToNumber(string input, out bool isSuccessful)
        {
            isSuccessful = int.TryParse(input, out int result);
            return isSuccessful ? result : 0;
        }

        public void Run()
        {
            Console.Write("Enter a string to parse into an integer: ");
            string input = Console.ReadLine();

            int number = ParseStringToNumber(input, out bool isSuccessful);

            if (isSuccessful)
            {
                Console.WriteLine($"Conversion successful! Parsed number: {number}");
            }
            else
            {
                Console.WriteLine("Conversion failed. Returning default value: 0");
            }
        }
    }
}
