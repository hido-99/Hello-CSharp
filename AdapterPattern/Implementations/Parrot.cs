using AdapterPattern.Contracts;
using System;

namespace AdapterPattern.Implementations
{
    class Parrot : IAnimal
    {
        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
