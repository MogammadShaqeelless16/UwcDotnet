using System;
using System.Collections.Generic;
using System.Text;
//contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.8

public static class Words
    {
        public static string CountCharactersInSentence(string inputString)
        {
            string New_inputString = inputString;
            string r = "";
            //int i = 0;
            New_inputString = New_inputString.Replace(" ", string.Empty);
            while (New_inputString != "")
            {
                char first = New_inputString[0];
                int Repeats = 1;
                for (int j = 1; j < New_inputString.Length; j++)
                {
                    if (New_inputString[j] == first)
                    {
                        Repeats++;
                    }
                }
                r += " " + first + " : " + Repeats + " ";
                New_inputString = New_inputString.Replace(new String(first, 1), string.Empty);
            }
            return r;
            /*foreach (var item in dict.Keys)
            {
                    //return " " + item + " : " + dict[item] + " " ;
                //return item;
                //return dict[item];
                string print;
                print = " " + item + " : " + dict[item] + " ";
                return print;
            }*/
            /*string array  inputString;
            array = array.Replace(" ", string.Empty);
            int count = 1;
                
            while (array.Length > 0)
                    {
                        
                        for (int j = 0; j < array.Length; j++)
                        {
                            if (array[0] == array[j])
                            {
                                count++;
                                Console.Write(" " + array[0] + "  :  " + j  + " " );
                            }
                        }
                        
                        array = array.Replace(array[0].ToString(), string.Empty);
                    } 
                    return count;*/
        }
    }


