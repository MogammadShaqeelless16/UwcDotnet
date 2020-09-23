using System;

namespace MPS_Assignment_3
{
        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Please Enter number to convert to words");
                string number;
                number = NumbWords(int.Parse(Console.ReadLine()));
                Console.WriteLine(number);
                //number = NumbWords.value;
                //Console.WriteLine(NumbWords(525));
            }


            public static string NumbWords(int value)
            {
                string[] Singles = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                string[] Doubles = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


                if (value >= 0 && value <= 20)
                {
                    return Singles[value];
                }
                else if (value < 100)
                {
                    return Doubles[value / 10] + ((value % 10 > 0) ? " " + NumbWords(value % 10) : "");
                }
                else if (value < 1000)
                {
                    return Singles[value / 100] + " Hundred" + ((value % 100 > 0) ? " And " + NumbWords(value % 100) : "");
                }
                else if (value < 100000)
                {
                    return NumbWords(value / 1000) + " Thousand " + ((value % 1000 > 0) ? " " + NumbWords(value % 1000) : "");
                }
                else if (value < 10000000)
                {
                    return NumbWords(value / 100000) + " Hundred and " + ((value % 100000 > 0) ? " " + NumbWords(value % 100000) : "");
                }
                else
                {
                    return value.ToString();
                    //return value;
                }
            }
        }
    }