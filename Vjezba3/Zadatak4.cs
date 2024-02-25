using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba3
{
    class Zadatak4
    {
        public void Igrica()
        {
            Random random = new Random();
            int targetValue = random.Next(1, 101);
            bool targetValueWasHit = false;
            int inputValue;
            Console.WriteLine("Unesite broj od 1 do 100 kako biste pogodili random broj: ");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out inputValue))
                {
                    Console.WriteLine("Neispravan input, nije broj");
                }
                else
                {
                    if(inputValue== targetValue)
                    {
                        Console.WriteLine("Svaka cast to je tocan broj,  "+ targetValue);
                        targetValueWasHit = true;
                    }
                    else if (inputValue < targetValue)
                    {
                        Console.WriteLine("Unesite veci broj ");
                    }
                    else
                    {
                        Console.WriteLine("Unesite manji broj");
                    }
                }
            } while (!targetValueWasHit);
        }
    }
}
