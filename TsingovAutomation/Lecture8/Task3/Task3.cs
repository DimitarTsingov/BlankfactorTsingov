using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 3 - . Create three classes named Animal, Dog and Cat

namespace Lecture8.Task3
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        // Constructor to set the animal's name and favorite food
        public Animal(string name)
        {
            Name = name;
        }

        // Method to simulate the animal eating
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {FavouriteFood}...");
        }
    }

    public class Dog : Animal
    {
        // Constructor to set the dog's name and call the base class constructor
        public Dog(string name) : base(name)
        {
        }

        // Method to simulate the dog barking
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking...");
        }
    }

    public class Cat : Animal
    {
        // Constructor to set the cat's name and call the base class constructor
        public Cat(string name) : base(name)
        {
        }

        // Method to simulate the cat meowing
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing...");
        }
    }

    public class Task3
    {
        public void Run()
        {
            // Prompt the user to enter the dog's name and favorite food
            Console.Write("Enter the dog's name: ");
            string dogName = Console.ReadLine();
            Console.Write("Enter the dog's favorite food: ");
            string dogFood = Console.ReadLine();

            // Create a Dog object and set its name and favorite food
            Dog dog = new Dog(dogName) { FavouriteFood = dogFood };

            // Prompt the user to enter the cat's name and favorite food
            Console.Write("Enter the cat's name: ");
            string catName = Console.ReadLine();
            Console.Write("Enter the cat's favorite food: ");
            string catFood = Console.ReadLine();

            // Create a Cat object and set its name and favorite food
            Cat cat = new Cat(catName) { FavouriteFood = catFood };

            // Make the dog eat and bark
            dog.Eat();
            dog.Bark();

            // Make the cat eat and meow
            cat.Eat();
            cat.Meow();
        }
    }
}
