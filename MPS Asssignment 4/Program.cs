using System;

namespace MPS_Asssignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string charCounts = Words.CountCharactersInSentence("Hello world");
            Console.WriteLine(charCounts);
        }
    }
}
