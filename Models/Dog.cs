using System;

namespace AnimalSolid.Models
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("собака кушает");
        }

        public override void Move()
        {
            Console.WriteLine("собака передвигается");
        }
    }
}