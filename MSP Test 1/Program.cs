using System;
using System.Linq;

namespace Question_1
{
    class program

    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 2, 1, 7, 4, 9, 5 };

            int SecondBiggest = Numbers.SecondBiggestNumber(myNumbers);
            int biggest = Numbers.BiggestNumber(myNumbers);
            string inputString = "i hope you had a good weekend?";
            string capitalString = Words.CapitalizeFirstWord(inputString);

            Console.WriteLine(SecondBiggest);
            Console.WriteLine(biggest);
            Console.WriteLine(capitalString);
        }

    }




}
