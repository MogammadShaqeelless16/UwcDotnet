using System;

namespace Fuzz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("ApplesPears");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Apples");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Pear");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
