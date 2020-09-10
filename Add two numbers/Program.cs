using System;

namespace Add_two_numbers
{
    class Program
    {
            public static double AddAndMultiply(double a, double b, double c)
            {
                return (a + b) * c;
            }
            static void Main(string[] args)
            {

                Console.WriteLine(AddAndMultiply(3, 6, 35));        // 315
                Console.WriteLine(AddAndMultiply(-12, 5, 17));      // -119
                Console.WriteLine(AddAndMultiply(-40, 50, 60));     // 600
                Console.WriteLine(AddAndMultiply(1.7, 9.9, 0.01));  // 0.116


            }
       
    }
    
}


