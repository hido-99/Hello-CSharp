using AdapterPattern.Contracts;
using System;

namespace AdapterPattern.Implementations
{
    class Male : IHuman
    {
        public void SpeakWords(string words)
        {
            Console.WriteLine(words);
        }
    }
}
