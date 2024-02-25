using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba3
{
    class Zadatak5
    {
        public static string PreokreniRijec(string intialString)
        {
            Stack<char> stack = new Stack<char>();
            string outputString = "";
            foreach(var slovo in intialString)
            {
                stack.Push(slovo);
            }

            while (stack.Count > 0)
            {
                outputString += stack.Pop();
            }

            return outputString;
        }
    }
}
