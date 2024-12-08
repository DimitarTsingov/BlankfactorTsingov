using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 5 - File Reader with Cleanup

namespace Lecture7
{
    public class Task5
    {
        public static void ReadFile(string filePath)
        {
            FileStream? fileStream = null;

            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileStream = null; 
                    Console.WriteLine("File Contents:");
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: File not found. {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: An I/O error occurred. {ex.Message}");
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                    Console.WriteLine("File stream closed.");
                }
            }
        }

        public void Run()
        {
            Console.Write("Enter the file path to read: ");
            string filePath = Console.ReadLine();

            ReadFile(filePath);
        }
    }
}
