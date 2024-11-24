using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    public class Task5
    {
        public void Run()
        {
            // Task 5 - Birthday Cake

            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int totalPieces = width * length;

            while (totalPieces > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP") break;
                totalPieces -= int.Parse(input);
            }

            if (totalPieces >= 0)
                Console.WriteLine($"{totalPieces} pieces are left.");
            else
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
        }
    }
}
