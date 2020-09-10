using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[] {"tegwen", "Euan" , "brett" , "tom"};

            for (int index = 0; index < students.Length; index++)
            {
                Console.WriteLine(students[index]);
            }
            
        }
    }
}
