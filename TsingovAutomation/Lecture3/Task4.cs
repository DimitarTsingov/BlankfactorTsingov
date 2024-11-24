using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    public class Task4
    {
        public void Run()
        {
            // Task 4 - Steps to Reach a Goal

            int goal = 10000;
            int steps = 0;

            while (steps < goal)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }
                steps += int.Parse(input);
            }

            if (steps >= goal)
                Console.WriteLine("Goal reached! Good job!");
            else
                Console.WriteLine($"{goal - steps} more steps to reach goal.");
        }
    }
}
