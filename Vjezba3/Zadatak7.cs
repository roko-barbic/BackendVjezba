using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba3
{
    class Zadatak7
    {
        public static int BrojSamoglasnika(string recenica)
        {
            int counter = 0;
            foreach (var item in recenica)
            {
                if(item == 'a' || item == 'A' || item == 'e' || item == 'E' || item == 'i' || item == 'I' || item == 'o' || item == 'O' || item == 'u' || item == 'U') {
                    counter++;
                }
            }
            return counter;
        }
    }
}
