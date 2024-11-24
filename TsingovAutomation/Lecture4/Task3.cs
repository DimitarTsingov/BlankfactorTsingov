using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Task3
    {
        public void Run()
        {
            // Task 3 - Train

            // Read the initial state of the train and max capacity
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                // Read the command
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                // Process the command
                string[] parts = command.Split();
                if (parts[0] == "Add")
                {
                    // Add a new wagon with the specified number of passengers
                    int passengers = int.Parse(parts[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    // Distribute passengers to existing wagons
                    int passengersToAdd = int.Parse(parts[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengersToAdd <= maxCapacity)
                        {
                            wagons[i] += passengersToAdd;
                            break; // Stop once the passengers are accommodated
                        }
                    }
                }
            }

            // Print the final state of the train
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
