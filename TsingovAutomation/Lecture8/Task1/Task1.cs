using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 1 - Create two classes named Animal and Dog

namespace Lecture8.Task1
{
    public class Animal
    {
        public string FavouriteFood { get; set; }

        public void Eat(string name)
        {
            Console.WriteLine($"{name} is eating {FavouriteFood}...");
        }
    }

    public class Dog : Animal
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking...");
        }
    }

    public class Task1
    {
        public void Run()
        {
            Console.Write("Enter the dog's name: ");
            string dogName = Console.ReadLine();

            Dog dog = new Dog(dogName);

            Console.Write("Enter the dog's favorite food: ");
            dog.FavouriteFood = Console.ReadLine();

            dog.Eat(dog.Name);

            dog.Bark();
            dog.Bark();
        }
    }
}
