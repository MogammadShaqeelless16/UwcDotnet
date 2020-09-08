using System;

namespace MPS_Assignment_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Code Challenges Section 1");
            Console.WriteLine("Accept text input and reverse it");
            Console.WriteLine("Please enter test to reverse ");
            string SInput = Console.ReadLine();
            string Rstring = "";
            int length;

            length = SInput.Length - 1;

            while (length >= 0)
            {
                Rstring = Rstring + SInput[length];
                length--;
            }
            Console.WriteLine("the text reverse is  ");
            Console.WriteLine(Rstring);


            Console.WriteLine("Is the inputted text a palindrome? (same forwards and backwards");
            bool b = SInput.Equals(Rstring, StringComparison.OrdinalIgnoreCase);

            if (b == true)
            {
                Console.WriteLine("" + SInput + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + SInput + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}
