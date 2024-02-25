using System;
using System.IO;  
namespace Vjezba3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak1
            //int input;
            //if (!int.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.WriteLine("Neispravan input, nije broj");
            //}
            //else
            //{
            //    if (input <= 9)
            //    {
            //        Zadatak1 zadatak1 = new Zadatak1(input);
            //        zadatak1.printPiramida(1);
            //    }
            //    else
            //        Console.WriteLine("Neispravan input, broj je veci od 9");
            //}

            //Zadatak2
            //int input;
            //if (!int.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.WriteLine("Neispravan input, nije broj");
            //}
            //else
            //{
            //    if (input <= 50)
            //    {

            //        Console.WriteLine(Zadatak2.Fibonnaci(input) + ", suma parni: " + Zadatak2.FibonnaciEvenSum(input) + ", suma neparni: " + Zadatak2.FibonnaciOddSum(input));
            //    }
            //    else
            //        Console.WriteLine("Neispravan input, broj je veci od 9");
            //}

            ////Zadatak3
            //float result;
            //Zadatak3 zadatak3 = new Zadatak3();
            //result = zadatak3.treciZadatak();
            //if (!zadatak3.isThereError)
            //{
            //    Console.WriteLine(result);
            //}

            ////Zadatak4
            //Zadatak4 zadatak4 = new Zadatak4();
            //zadatak4.Igrica();

            //Zadatak5
            //string inputString = Console.ReadLine();
            //string outputString = Zadatak5.PreokreniRijec(inputString);
            //Console.WriteLine(outputString);

            ////Zadatak6
            //Console.WriteLine("Unesite neku recenicu: ");
            //string inputString2 = Console.ReadLine();
            //Console.WriteLine("Najkraca rijec je: " + Zadatak6.findShortesWord(inputString2) + "\n Najduza rijec je: " + Zadatak6.findLongestWord(inputString2));

            ////Zadatak7
            //Console.WriteLine("Broj samoglasnika: " + Zadatak7.BrojSamoglasnika(inputString2));
            //Console.ReadKey();

            //Zadatak8
            string writeText = "Evo nesto pisem";
            File.WriteAllText(@"D:\backendEdu\Vjezba3\zadatak8.txt.txt", writeText);

            string readText = File.ReadAllText("zadatak8.txt");
            Console.WriteLine(readText);
        }
    }
}
