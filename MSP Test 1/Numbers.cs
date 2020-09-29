using System;
using System.Linq;

class Numbers
{


    public static int BiggestNumber(int[] numbers)
    {
        int biggest = numbers.Max();

        return biggest;
    }

    public static int SecondBiggestNumber(int[] numbers)
    {
        int second = numbers.OrderByDescending(z => z).Skip(1).First();
        return second;
    }

}