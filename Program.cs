using System;
using AnimalSolid.Models;
using AnimalSolid.Interfaces;

namespace AnimalSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Cat();
            animal.Eat();
            animal.Move();
            animal = new Dog();
            animal.Eat();
            animal.Move();
        }
    }
}
