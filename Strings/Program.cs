using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txts = "Hello World";
            Console.WriteLine(txts.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txts.ToLower());   // Outputs "hello world"

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string firstNames = "John ";
            string lastNames = "Doe";
            string names = string.Concat(firstNames, lastNames);
            Console.WriteLine(names);

            string firstNam = "John";
            string lastNam = "Doe";
            string nam = $"My full name is: {firstNam} {lastNam}";
            Console.WriteLine(nam);
        }
    }
}
