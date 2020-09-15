using System;

namespace MSP_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 99;
            while (i != 0)
            {
                Console.WriteLine(i + " Bottles of beer on the wall," + i + " Bottles of beer");
                i--;
                Console.WriteLine("Take one down and pass it around," + i + " Bottles of beer on the wall");
            }
        }
    }
}
