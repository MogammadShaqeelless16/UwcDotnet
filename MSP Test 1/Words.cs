using System;
using System.Linq;

class Words
{
    public static string CapitalizeFirstWord(string sentence)
    {

        char[] array = sentence.ToCharArray();
        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        for (int Word = 1; Word < array.Length; Word++)
        {
            if (array[Word - 1] == ' ')
            {
                if (char.IsLower(array[Word]))
                {
                    array[Word] = char.ToUpper(array[Word]);
                }
            }
        }
        return new string(array);

    }

}