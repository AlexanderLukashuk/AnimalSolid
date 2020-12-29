using System;
using AnimalSolid.Interfaces;

namespace AnimalSolid.Models
{
    public class Animal : IEat, IMove
    {
        public string Name { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("кушает");
        }

        public virtual void Move()
        {
            Console.WriteLine("передвигается");
        }
    }
}