using AdapterPattern.Contracts;
using System;

namespace AdapterPattern.Implementations
{
    class Dog : IAnimal
    {
        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
