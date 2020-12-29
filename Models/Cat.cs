using System;

namespace AnimalSolid.Models
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("кошка кушает");
        }

        public override void Move()
        {
            Console.WriteLine("кошка передвигается");
        }
    }
}