using System;

namespace overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.animal();
            Horse horse = new Horse();
            horse.animal();
        }
    }

    class Animal
    {
        public void animal()
        {
            Console.WriteLine("Dit is een enimol");
        }
    }

    class Horse : Animal
    {

    }
}
