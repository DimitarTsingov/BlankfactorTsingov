using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 2 - Create three classes named Animal, Dog and Puppy

namespace Lecture8.Task2
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {FavouriteFood}...");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking...");
        }
    }

    public class Puppy : Dog
    {
        public Puppy(string name) : base(name)
        {
        }

        public void Weep()
        {
            Console.WriteLine($"{Name} is weeping...");
        }
    }

    public class Task2
    {
        public void Run()
        {
            Console.Write("Enter the dog's name: ");
            string dogName = Console.ReadLine();
            Console.Write("Enter the dog's favorite food: ");
            string dogFood = Console.ReadLine();

            Dog dog = new Dog(dogName) { FavouriteFood = dogFood };

            Console.Write("Enter the puppy's name: ");
            string puppyName = Console.ReadLine();
            Console.Write("Enter the puppy's favorite food: ");
            string puppyFood = Console.ReadLine();

            Puppy puppy = new Puppy(puppyName) { FavouriteFood = puppyFood };

            dog.Eat();
            dog.Bark();

            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
