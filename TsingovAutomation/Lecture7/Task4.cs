using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 4 - Custom Exception

namespace Lecture7
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    public class Task4
    {
        public static string ValidateAge(int age)
        {
            if (age < 0 || age > 150)
            {
                throw new InvalidAgeException($"Invalid age: {age}. Age must be between 0 and 150.");
            }

            return "Age is valid.";
        }

        public void Run()
        {
            try
            {
                Console.Write("Enter the age to validate: ");
                int age = int.Parse(Console.ReadLine());

                string result = ValidateAge(age);
                Console.WriteLine(result);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer for age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
