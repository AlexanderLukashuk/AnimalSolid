using System;
using AnimalSolid.Interfaces;

namespace AnimalSolid.Models
{
    // S - SRP - класс Animal выполняет только необходиме функции, методы для этого класса
    
    // D и I - класс Animal наследуется от нескольких интерфейсов и переопределяет
    // виртуально методы интерфейсов, блягодаря этому наследникам не придется
    // реализовывать все методы, а только нужно будет реализовать самые необходимые
    public abstract class Animal : IEat, IMove
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