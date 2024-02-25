using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba3
{
    class Zadatak1
    {
        public int NumberOfRows { get; set; }

        public Zadatak1(int numberOfRows)
        {
            NumberOfRows = numberOfRows;
        }

        public void printPiramida(int currentRow)
        {
            int counter = 0;
            bool flagForOpposite = false;
            for (int i = NumberOfRows; i >= -NumberOfRows; i--)
            {
                if(i > currentRow)
                {
                    Console.Write(" ");
                }
                else
                {
                    if (flagForOpposite)
                    {
                        counter--;
                    }
                    else
                    {
                        counter++;
                    }
                    if (counter == currentRow)
                    {
                        flagForOpposite = true;
                    }
                    if(counter > 0)
                    {
                        Console.Write(counter);
                    }
                }
            }
            Console.Write("\n");
            if(currentRow < NumberOfRows)
            {
                printPiramida(currentRow + 1);
            }
        }
    }
}
