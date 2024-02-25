using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba3
{
    class Zadatak6
    {
        public static string findShortesWord(string sentence)
        {
            int start = 0;
            int minLenght = 500;
            int counter = 0;
            string output = "";
            for(int i = 0; i< sentence.Length; i++)
            {
                counter++;
                if(sentence[i] == ' ' || sentence[i] == ',' || sentence[i] == '.')
                {
                    if(minLenght > counter)
                    {
                        minLenght = counter;
                        start = i - counter +1 ;
                    }
                    counter = 0;
                }
            }
            for (int i = start; i < start + minLenght -1 ; i++)
            {
                output += sentence[i];
            }
            return output;
        }


        public static string findLongestWord(string sentence)
        {
            int start = 0;
            int maxLenght = 0;
            int counter = 0;
            string output = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                counter++;
                if (sentence[i] == ' ' || sentence[i] == ',' || sentence[i] == '.')
                {
                    if (maxLenght < counter)
                    {
                        maxLenght = counter;
                        start = i - counter + 1;
                    }
                    counter = 0;
                }
            }
            for (int i = start; i < start + maxLenght -1; i++)
            {
                output += sentence[i];
            }
            return output;
        }
    }
}
