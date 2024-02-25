using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba3
{
    class Zadatak3
    {
        public int Broj1 { get; set; }
        public int Broj2 { get; set; }
        public string ChosenOperator { get; set; }
        public bool isThereError { get; set; }

        public void getValues()
        {
            isThereError = false;
            Console.Write("Unesite prvi broj: ");
            Broj1 = checkValuesForNumber();
            Console.Write("\nUnesite drugi broj: ");
            Broj2 = checkValuesForNumber();
            Console.Write("\nUnesite operator: ");
            ChosenOperator = Console.ReadLine();
        }

        public float treciZadatak()
        {
            float result;
            getValues();
            if (!isThereError)
            {
                switch (ChosenOperator)
                {
                    case "+":
                        result = Broj1 + Broj2;
                        break;
                    case "-":
                        result = Broj1 - Broj2;
                        break;
                    case "/":
                        result =(float) Broj1 / Broj2;
                        break;
                    case "*":
                        result = Broj1 * Broj2;
                        break;
                    case "%":
                        result =(float) Broj1 % Broj2;
                        break;
                    case "Sve":
                        result = 0;
                        Console.WriteLine("+ => " + (Broj1 + Broj2));
                        Console.WriteLine("- => " + (Broj1 - Broj2));
                        Console.WriteLine("/ => " + ((float)Broj1 / Broj2));
                        Console.WriteLine("* => " + (Broj1 * Broj2));
                        Console.WriteLine("% => " + ((float)Broj1 % Broj2));
                        isThereError = true;
                        break;
                    default:
                        Console.WriteLine("Nije usnesen ispravni operator");
                        result = 0;
                        break;
                }
            }
            else
            {
                result = 0;
                Console.WriteLine("Došlo je do greške prilikom unosa parametara");
            }
                           
            return result;
        }
        public int checkValuesForNumber()
        {
            int input;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Neispravan input, nije broj");
                isThereError = true;
                return 0;
            }
            return input;
        }
    }
}
