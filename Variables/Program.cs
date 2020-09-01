using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Variables
            string name = "John";
            Console.WriteLine("Hello " + name);

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);

            //Declare Many Variables
            int a = 5, b = 6, z = 50;
            Console.WriteLine(a + b + z);

            //C# Identifiers

            // Good
            int minutesPerHour = 60;

            // OK, but not so easy to understand what m actually is
            int m = 60;

            Console.WriteLine(minutesPerHour);
            Console.WriteLine(m);

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");


            //Work with double types

            Console.WriteLine("Work with double types");

            double e = 19;
            double f = 23;
            double c = 8;
            double d = (e + f) / c;
            Console.WriteLine(d);

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            double maxi = double.MaxValue;
            double mini = double.MinValue;
            Console.WriteLine($"The range of double is {mini} to {maxi}");


            //Work with decimal types

            Console.WriteLine("Work with decimal types");
            decimal mine = decimal.MinValue;
            decimal maxe = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {mine} to {maxe}");

            double g = 1.0;
            double h = 3.0;
            Console.WriteLine(g / h);

            decimal j = 1.0M;
            decimal k = 3.0M;
            Console.WriteLine(j / k);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
