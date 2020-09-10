using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        public static string CtoF(double celsius)
        {
            double fahrenheit;

            if (celsius < -273.15)
            {
                return "Temperature below absolute zero!";
            }

            fahrenheit = celsius * 1.8 + 32;

            return $"T = {fahrenheit}F";
        }
        static void Main(string[] args)
        {

            Console.WriteLine(CtoF(0));     // T = 32F
            Console.WriteLine(CtoF(-300));  // Temperature below absolute zero!
            Console.WriteLine(CtoF(28.5));  // T = 83.3F


        }

    }
}
